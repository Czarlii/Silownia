namespace SilowniaLib
{
    public class PlanTreningu : IKaloryczny
    {
        public string Nazwa { get; set; } = string.Empty;
        public int IdCzlonka { get; set; }
        public List<Cwiczenie> Cwiczenia { get; set; } = new List<Cwiczenie>();

        public void DodajCwiczenie(Cwiczenie cwiczenie)
        {
            Cwiczenia.Add(cwiczenie);
        }

        public void UsunCwiczenie(string nazwa)
        {
            Cwiczenie? doUsuniecia = Cwiczenia.FirstOrDefault(c => c.Nazwa == nazwa);
            if (doUsuniecia != null)
                Cwiczenia.Remove(doUsuniecia);
        }

        public double ObliczLaczneKalorie()
        {
            return Cwiczenia.Sum(c => c.ObliczKalorie());
        }

        // Implementacja interfejsu IKaloryczny
        public double ObliczKalorie()
        {
            return ObliczLaczneKalorie();
        }

        public List<Cwiczenie> PobierzPoTypie(string typ)
        {
            return Cwiczenia.Where(c => c.GetType().Name.Contains(typ)).ToList();
        }

        public override string ToString()
        {
            return $"Plan: {Nazwa} | Cwiczenia: {Cwiczenia.Count} | Kalorie: {ObliczLaczneKalorie():F1} kcal";
        }
    }
}
