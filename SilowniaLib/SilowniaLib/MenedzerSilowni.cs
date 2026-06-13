using System.Text.Json;

namespace SilowniaLib
{
    public class MenedzerSilowni
    {
        private List<Czlonek> czlonkowie = new List<Czlonek>();
        private List<Cwiczenie> cwiczenia = new List<Cwiczenie>();
        private List<PlanTreningu> plany = new List<PlanTreningu>();
        private int nastepneId = 1;

        public event CzlonekDelegate? OnCzlonekDodany;
        public event CzlonekDelegate? OnCzlonekUsuniety;

        // ===== CZLONKOWIE =====

        public void DodajCzlonka(Czlonek czlonek)
        {
            if (czlonkowie.Any(c => c.NumerTelefonu == czlonek.NumerTelefonu))
                throw new CzlonekJuzIstniejeWyjatek(czlonek.NumerTelefonu);

            czlonek.Id = nastepneId++;
            czlonkowie.Add(czlonek);
            OnCzlonekDodany?.Invoke(czlonek);
        }

        public void UsunCzlonka(int id)
        {
            Czlonek? czlonek = czlonkowie.FirstOrDefault(c => c.Id == id);
            if (czlonek == null)
                throw new CzlonekNieZnalezionyWyjatek(id.ToString());

            czlonkowie.Remove(czlonek);

            // Usun plan treningowy czlonka jesli istnieje
            PlanTreningu? plan = plany.FirstOrDefault(p => p.IdCzlonka == id);
            if (plan != null)
                plany.Remove(plan);

            OnCzlonekUsuniety?.Invoke(czlonek);
        }

        public void AktualizujCzlonka(Czlonek zaktualizowany)
        {
            Czlonek? istniejacy = czlonkowie.FirstOrDefault(c => c.Id == zaktualizowany.Id);
            if (istniejacy == null)
                throw new CzlonekNieZnalezionyWyjatek(zaktualizowany.Id.ToString());

            if (istniejacy.NumerTelefonu != zaktualizowany.NumerTelefonu &&
                czlonkowie.Any(c => c.NumerTelefonu == zaktualizowany.NumerTelefonu))
                throw new CzlonekJuzIstniejeWyjatek(zaktualizowany.NumerTelefonu);

            istniejacy.Imie = zaktualizowany.Imie;
            istniejacy.Nazwisko = zaktualizowany.Nazwisko;
            istniejacy.NumerTelefonu = zaktualizowany.NumerTelefonu;
            istniejacy.DataUrodzenia = zaktualizowany.DataUrodzenia;
            istniejacy.WagaKg = zaktualizowany.WagaKg;
        }

        public List<Czlonek> PobierzCzlonkow()
        {
            return czlonkowie.OrderBy(c => c.Nazwisko).ToList();
        }

        public Czlonek? ZnajdzCzlonka(int id)
        {
            return czlonkowie.FirstOrDefault(c => c.Id == id);
        }

        // ===== CWICZENIA =====

        public void DodajCwiczenie(Cwiczenie cwiczenie)
        {
            if (cwiczenia.Any(c => c.Nazwa == cwiczenie.Nazwa))
                throw new CwiczenieJuzIstniejeWyjatek(cwiczenie.Nazwa);

            cwiczenia.Add(cwiczenie);
        }

        public void UsunCwiczenie(string nazwa)
        {
            Cwiczenie? cwiczenie = cwiczenia.FirstOrDefault(c => c.Nazwa == nazwa);
            if (cwiczenie != null)
                cwiczenia.Remove(cwiczenie);
        }

        public List<Cwiczenie> PobierzCwiczenia()
        {
            return cwiczenia.OrderBy(c => c.Nazwa).ToList();
        }

        // ===== PLANY =====

        public void StworzPlan(int idCzlonka, string nazwaPlan)
        {
            if (czlonkowie.FirstOrDefault(c => c.Id == idCzlonka) == null)
                throw new CzlonekNieZnalezionyWyjatek(idCzlonka.ToString());

            PlanTreningu plan = new PlanTreningu
            {
                Nazwa = nazwaPlan,
                IdCzlonka = idCzlonka
            };
            plany.Add(plan);
        }

        public PlanTreningu? PobierzPlanCzlonka(int idCzlonka)
        {
            return plany.FirstOrDefault(p => p.IdCzlonka == idCzlonka);
        }

        public void UsunPlan(int idCzlonka)
        {
            PlanTreningu? plan = plany.FirstOrDefault(p => p.IdCzlonka == idCzlonka);
            if (plan == null)
                throw new PlanNieZnalezionyWyjatek(idCzlonka.ToString());

            plany.Remove(plan);
        }

        public List<PlanTreningu> PobierzWszystkiePlany()
        {
            return plany;
        }

        // ===== LINQ STATYSTYKI =====

        public double ObliczKalorieCzlonka(int idCzlonka)
        {
            PlanTreningu? plan = PobierzPlanCzlonka(idCzlonka);
            if (plan == null) return 0;
            return plan.ObliczLaczneKalorie();
        }

        public List<string> WszyscyCzlonkowieZKaloriami()
        {
            return czlonkowie
                .Select(c => $"{c.ImieNazwisko}: {ObliczKalorieCzlonka(c.Id):F1} kcal")
                .ToList();
        }

        public List<string> NajlepsiCzlonkowie(int top)
        {
            return czlonkowie
                .OrderByDescending(c => ObliczKalorieCzlonka(c.Id))
                .Take(top)
                .Select(c => $"{c.ImieNazwisko}: {ObliczKalorieCzlonka(c.Id):F1} kcal")
                .ToList();
        }

        public List<string> GrupujCwiczenieaPoTypie()
        {
            return cwiczenia
                .GroupBy(c => c.GetType().Name)
                .Select(g => $"{g.Key}: {g.Count()} cwiczen")
                .ToList();
        }

        public double SredniaKaloriiNaTrening()
        {
            if (!plany.Any()) return 0;
            return plany.Average(p => p.ObliczLaczneKalorie());
        }

        // ===== JSON =====

        private static readonly JsonSerializerOptions opcjeJson = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public void Zapisz(string sciezka)
        {
            DaneSilowni dane = new DaneSilowni
            {
                Czlonkowie = czlonkowie,
                Cwiczenia = cwiczenia,
                Plany = plany,
                NastepneId = nastepneId
            };
            string json = JsonSerializer.Serialize(dane, opcjeJson);
            File.WriteAllText(sciezka, json);
        }

        public void Wczytaj(string sciezka)
        {
            if (!File.Exists(sciezka)) return;
            string json = File.ReadAllText(sciezka);
            DaneSilowni? dane = JsonSerializer.Deserialize<DaneSilowni>(json, opcjeJson);
            if (dane != null)
            {
                czlonkowie = dane.Czlonkowie ?? new List<Czlonek>();
                cwiczenia = dane.Cwiczenia ?? new List<Cwiczenie>();
                plany = dane.Plany ?? new List<PlanTreningu>();
                nastepneId = dane.NastepneId;
            }
        }
    }

    public class DaneSilowni
    {
        public List<Czlonek> Czlonkowie { get; set; } = new List<Czlonek>();
        public List<Cwiczenie> Cwiczenia { get; set; } = new List<Cwiczenie>();
        public List<PlanTreningu> Plany { get; set; } = new List<PlanTreningu>();
        public int NastepneId { get; set; } = 1;
    }
}
