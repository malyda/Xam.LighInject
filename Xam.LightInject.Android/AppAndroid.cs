using Xam.LightInject.Droid.CrossplatformService;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.Droid
{
    class AppAndroid : LightInject.App
    {
        public AppAndroid()
        {
            RegisterService(typeof(ICrossplatformService), typeof(CrossplatformServiceImplementation));
            RegisterService(typeof(IDeviceIdentification), typeof(DeviceIdentificationImplementation));
        }
    }
}