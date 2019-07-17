using LightInject;
using Xam.LighInject.Service.CrossplatformServices;
using Xam.LighInject.UWP.CrossplatformService;

namespace Xam.LighInject.UWP
{
    public class AppUWP : LighInject.App
    {
        public AppUWP()
        {
            RegisterService(typeof(ICrossplatformService), typeof(CrossplatformServiceImplementation));
        }
    }
}
