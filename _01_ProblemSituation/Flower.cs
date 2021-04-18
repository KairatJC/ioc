using System;

namespace ioc._01_ProblemSituation
{
    public class Flower
    {
        private Lamp LightSource { get; set; }

        public Flower()
        {
            LightSource = new Lamp();
        }

        /* As far as I understand:
        method StartPhotosynthesis depend of Lamp.LightOn method
        and if Lamp.LightOn will be changed in future, I need to check what happend here.
        */
        public void StartPhotosynthesis()
        {
            var lightLevel = LightSource.LightOn();
            if (lightLevel > 5)
            {
                Console.WriteLine("--=[ Flower love you ( ＾◡＾)っ ♡ \n");
                return;
            }
            Console.WriteLine($"--=[ Flower dead without light ({lightLevel}) (×_×) \n");
        }
    }
}
