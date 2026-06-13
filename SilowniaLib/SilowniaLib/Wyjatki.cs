namespace SilowniaLib
{
    public class CzlonekJuzIstniejeWyjatek : Exception
    {
        public CzlonekJuzIstniejeWyjatek(string nrTelefonu)
            : base($"Czlonek o numerze telefonu '{nrTelefonu}' juz istnieje!") { }
    }

    public class CzlonekNieZnalezionyWyjatek : Exception
    {
        public CzlonekNieZnalezionyWyjatek(string nrTelefonu)
            : base($"Nie znaleziono czlonka o numerze telefonu '{nrTelefonu}'!") { }
    }

    public class CwiczenieJuzIstniejeWyjatek : Exception
    {
        public CwiczenieJuzIstniejeWyjatek(string nazwa)
            : base($"Cwiczenie '{nazwa}' juz istnieje!") { }
    }

    public class PlanNieZnalezionyWyjatek : Exception
    {
        public PlanNieZnalezionyWyjatek(string nrTelefonu)
            : base($"Nie znaleziono planu treningowego dla czlonka '{nrTelefonu}'!") { }
    }
}
