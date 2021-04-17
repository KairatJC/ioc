using System;

namespace ioc.DependencyInjection
{
    public class Wind : IWind
    {
        // low-level module
        // Sunlower doesn't depend on this concrete Class
        public int Woooo()
        {
            Console.WriteLine("\n--=[ Wind do wooo •·.·¯`·.·•\n");
            var random = new Random();
            return random.Next(10);
        }
    }
}