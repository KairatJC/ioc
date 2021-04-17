namespace ioc.Absaction
{
    public class SunFactory
    {
        public static ISunLight GetSunObj()
        {
            return new SunLight();
        }
    }
}