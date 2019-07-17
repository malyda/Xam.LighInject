using LightInject;
using Xam.LightInject.Service.CrossplatformServices;
using Xam.LightInject.UWP.CrossplatformService;

namespace Xam.LightInject.UWP
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
