namespace ioc._02_FabricMethod
{
    public class WaterFactory
    {
        public static Water GetWaterObj()
        {
            return new Water();
        }
    }
}