namespace SilowniaLib
{
    public enum Intensywnosc
    {
        Niska,
        Srednia,
        Wysoka
    }

    public class CwiczenieKardio : Cwiczenie
    {
        public double Dystans { get; set; }
        public Intensywnosc Intensywnosc { get; set; }

        public override double ObliczKalorie()
        {
            double wspolczynnik = Intensywnosc switch
            {
                Intensywnosc.Niska => 40,
                Intensywnosc.Srednia => 60,
                Intensywnosc.Wysoka => 80,
                _ => 50
            };
            return Dystans * wspolczynnik;
        }

        public override string ToString()
        {
            return $"[Kardio] {Nazwa} - {Dystans}km ({Intensywnosc}) - {ObliczKalorie():F1} kcal";
        }
    }
}
