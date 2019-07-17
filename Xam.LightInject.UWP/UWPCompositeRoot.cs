using LightInject;
using Xam.LighInject.Service.CrossplatformServices;
using Xam.LighInject.UWP.CrossplatformService;

namespace Xam.LighInject.UWP
{
    /// <summary>
    /// Note: Any other services contained within the target assembly that is not registered in the composition root, will NOT be registered.
    /// </summary>
    class UWPCompositeRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register(typeof(ICrossplatformService), typeof(CrossplatformServiceImplementation));
        }
    }
}
