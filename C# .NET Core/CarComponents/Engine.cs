namespace CarCatalog.CarComponents
{
    public class Engine
    {
        public readonly Cylinders Size;
        public readonly int HorsePower;
        public readonly int CityMPG;
        public readonly int HighwayMPG;
    
        public Engine(Cylinders cylinders, int horsePower, int cityMPG, int hwyMPG)
        {
            Size = cylinders;
            HorsePower = horsePower;
            CityMPG = cityMPG;
            HighwayMPG = hwyMPG;
        }

        public enum Cylinders
        {
            I4 = 4,
            V6 = 6,
            V8 = 8
        }
    }
}