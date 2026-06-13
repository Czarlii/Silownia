namespace SilowniaLib
{
    public class CwiczenieRozciagajace : Cwiczenie
    {
        public string GrupaMiesniowa { get; set; } = string.Empty;

        public override double ObliczKalorie()
        {
            return CzasTrwaniaMinuty * 2;
        }

        public override string ToString()
        {
            return $"[Rozciagajace] {Nazwa} - {GrupaMiesniowa} - {ObliczKalorie():F1} kcal";
        }
    }
}
