namespace SilowniaLib
{
    public class CwiczenieSilowe : Cwiczenie
    {
        public int LiczbaSerii { get; set; }
        public int LiczbaPowtorzen { get; set; }
        public double CiezarKg { get; set; }

        public override double ObliczKalorie()
        {
            return CiezarKg * LiczbaSerii * LiczbaPowtorzen * 0.1;
        }

        public override string ToString()
        {
            return $"[Silowe] {Nazwa} - {LiczbaSerii}x{LiczbaPowtorzen} @ {CiezarKg}kg - {ObliczKalorie():F1} kcal";
        }
    }
}
