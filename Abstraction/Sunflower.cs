using System;

namespace ioc.Abstraction
{
    public class Sunflower
    {
        // High-level module
        private ISunLight _sunLight;

        public Sunflower() {
            _sunLight = SunFactory.GetSunObj();
        }

        public void Shining()
        {
            var SunLevel = _sunLight.SunShine();
            if (SunLevel > 5)
            {
                Console.WriteLine("--=[ Sunny day today ♡ \n");
                return;
            }
            Console.WriteLine($"--=[ Sunflower dead without Sun ({SunLevel}) (×_×) \n");
        }
    }
}
