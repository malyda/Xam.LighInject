using Xam.LightInject.Service.CrossplatformServices;
using Xam.LightInject.UWP.CrossplatformService;

namespace Xam.LightInject.UWP
{
    public class AppUWP : LightInject.App
    {
        public AppUWP()
        {
            RegisterService(typeof(ICrossplatformService), typeof(CrossplatformServiceImplementation));
            RegisterService(typeof(IDeviceIdentification), typeof(DeviceIdentificationImplementation));
        }
    }
}
