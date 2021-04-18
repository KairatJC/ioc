namespace ioc._03_Abstraction
{
    public class SunFactory
    {
        public static ISunLight GetSunObj()
        {
            return new SunLight();
        }
    }
}