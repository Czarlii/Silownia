using System.Text.Json.Serialization;

namespace SilowniaLib
{
    [JsonDerivedType(typeof(CwiczenieSilowe), "silowe")]
    [JsonDerivedType(typeof(CwiczenieKardio), "kardio")]
    [JsonDerivedType(typeof(CwiczenieRozciagajace), "rozciagajace")]
    public abstract class Cwiczenie : IComparable<Cwiczenie>, IKaloryczny
    {
        public string Nazwa { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public int CzasTrwaniaMinuty { get; set; }

        public abstract double ObliczKalorie();

        public int CompareTo(Cwiczenie? inne)
        {
            return CzasTrwaniaMinuty.CompareTo(inne?.CzasTrwaniaMinuty);
        }

        public override string ToString()
        {
            return $"{Nazwa} ({CzasTrwaniaMinuty} min) - {ObliczKalorie():F1} kcal";
        }
    }
}
