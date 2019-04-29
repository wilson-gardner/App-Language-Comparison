using CarCatalog.CarComponents;

namespace CarCatalog.Options
{
    public class Package
    {
        public readonly string Name;
        public readonly double Price;
        public readonly Engine Engine;
        public readonly Paint PaintScheme;

        public Package(string name, double price, Engine engineConfig, Paint paintConfig)
        {
            Name = name;
            Price = price;
            Engine = engineConfig;
            PaintScheme = paintConfig;
        }
    }
}