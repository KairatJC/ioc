using System;

namespace ioc.DependencyInjection
{
    public class Poppy
    {
        // High-level module
        private IWind _wind;

        public Poppy(IWind wind) {
            _wind = wind;
        }

        public Poppy() {
            _wind = WindFactory.GetWindObj();
        }

        public void DispersingSeeds()
        {
            var windLevel = _wind.Woooo();
            if (windLevel > 5)
            {
                Console.WriteLine("--=[ More Poppy ♡ \n");
                return;
            }
            Console.WriteLine($"--=[ Little Poppy doesn't spread seeds ({windLevel}) (-_-) \n");
        }
    }
}
