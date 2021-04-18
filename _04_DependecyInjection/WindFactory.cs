namespace ioc._04_DependecyInjection
{
    public class WindFactory
    {
        public static IWind GetWindObj()
        {
            return new Wind();
        }
    }
}