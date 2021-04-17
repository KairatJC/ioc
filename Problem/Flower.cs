using System;

namespace ioc.Problem
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
        and if Lamp.LightOn will be changed in future, I need to test what happend here.

        Reason: "if I have 100 methods I need to test 100 times" sounds unconvincing.
        because in real I haven't 100 methods. Maybe I'm wrong
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
