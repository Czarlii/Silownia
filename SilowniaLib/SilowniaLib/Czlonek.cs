namespace SilowniaLib
{
    public class Czlonek : IComparable<Czlonek>
    {
        public int Id { get; set; }
        public string NumerTelefonu { get; set; } = string.Empty;
        public string Imie { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public DateTime DataUrodzenia { get; set; }
        public DateTime DataDolaczenia { get; set; }
        public double WagaKg { get; set; }

        public string ImieNazwisko => $"{Imie} {Nazwisko}";

        public int CompareTo(Czlonek? inne)
        {
            return string.Compare(Nazwisko, inne?.Nazwisko, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{ImieNazwisko} | Tel: {NumerTelefonu} | Waga: {WagaKg}kg | Dolaczyl: {DataDolaczenia:dd.MM.yyyy}";
        }
    }
}
