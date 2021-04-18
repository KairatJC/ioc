using System;

namespace ioc._01_ProblemSituation
{
    public class Lamp
    {
        private Electricity Electricity { get; set; }

        public Lamp()
        {
            Electricity = new Electricity();
        }

        public int LightOn()
        {
            Electricity.getEnergy("Lamp");
            Console.WriteLine("--=[ Rays of light begin to give joy ᕕ( ᐛ )ᕗ \n");
            var random = new Random();
            return random.Next(10);
        }
    }
}
