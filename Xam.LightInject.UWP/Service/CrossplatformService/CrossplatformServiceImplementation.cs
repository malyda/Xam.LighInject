using System.Diagnostics;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LighInject.UWP.Service.CrossplatformService
{
    public class CrossplatformServiceImplementation : ICrossplatformService
    {
        public void DoSomethingCrossplatform()
        {
            Debug.WriteLine("CrossplatformService service DoSomethingCrossplatform method called in UWP.");
        }
    }
}
