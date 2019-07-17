using LightInject;
using Xam.LightInject.Droid.CrossplatformService;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.Droid
{
    /// <summary>
    /// Note: Any other services contained within the target assembly that is not registered in the composition root, will NOT be registered.
    /// </summary>
    class AndroidCompositeRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register(typeof(ICrossplatformService), typeof(CrossplatformServiceImplementation));
        }
    }
}