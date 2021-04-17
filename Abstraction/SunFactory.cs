namespace ioc.Abstraction
{
    public class SunFactory
    {
        public static ISunLight GetSunObj()
        {
            return new SunLight();
        }
    }
}