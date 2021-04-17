namespace ioc.FactoryPattern
{
    public class WaterFactory
    {
        public static Water GetWaterObj()
        {
            return new Water();
        }
    }
}