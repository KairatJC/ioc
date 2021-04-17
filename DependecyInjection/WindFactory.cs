namespace ioc.DependencyInjection
{
    public class WindFactory
    {
        public static IWind GetWindObj()
        {
            return new Wind();
        }
    }
}