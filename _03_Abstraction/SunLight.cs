using System;

namespace ioc._03_Abstraction
{
    public class SunLight : ISunLight
    {
        // low-level module
        // Sunlower doesn't depend on this concrete Class
        public int SunShine()
        {
            Console.WriteLine("\n--=[ Shiny Sunny 彡ﾟ◉ω◉ )つー☆* \n");
            var random = new Random();
            return random.Next(10);
        }
    }
}