using System;

namespace ioc.FactoryPattern
{
    public class Rose
    {
        public Rose() { }

        public void StartGrowing()
        {
            var waterSource = WaterFactory.GetWaterObj();
            var waterLevel = waterSource.ToWater();
            if (waterLevel > 5)
            {
                Console.WriteLine("--=[ Roses love you ( ＾◡＾)っ ♡ \n");
                return;
            }
            Console.WriteLine($"--=[ Roses dead without water ({waterLevel}) (×_×) \n");
        }
    }
}
