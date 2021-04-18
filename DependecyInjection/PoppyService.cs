using System;

namespace ioc.DependencyInjection
{
    public class PoppyService
    {
        private Poppy _poppy;

        public PoppyService()
        {
            _poppy = new Poppy(new Wind());
        }

        public void Disperse()
        {
            _poppy.DispersingSeeds();
        }
    }
}
