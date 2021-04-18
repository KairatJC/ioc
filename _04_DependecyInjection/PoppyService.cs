using System;

namespace ioc._04_DependecyInjection
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
