using System;

namespace ioc.FactoryPattern
{
    public class Water
    {
        public int ToWater()
        {
            Console.WriteLine("\n--=[ Your Roses Love Water ( ＾◡＾)っ ♡ \n");
            var random = new Random();
            return random.Next(10);
        }
    }
}
