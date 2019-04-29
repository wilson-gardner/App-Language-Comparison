namespace CarCatalog.CarComponents
{
    public class Paint
    {
        public readonly string Name;
        public readonly PaintClass Class;
        public readonly int[] RGB;

        public Paint(string colorName, PaintClass paintClass, int[] rgb)
        {
            Name = colorName;
            Class = paintClass;
            RGB = rgb;
        }

        public enum PaintClass
        {
            Premium,
            Plus,
            Base
        }
    }
}