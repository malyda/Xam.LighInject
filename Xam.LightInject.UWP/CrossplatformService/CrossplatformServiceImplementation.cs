using System.Diagnostics;
using Xam.LighInject.Service.CrossplatformServices;

namespace Xam.LighInject.UWP.CrossplatformService
{
    public class CrossplatformServiceImplementation : ICrossplatformService
    {
        public void DoSomethingCrossplatform()
        {
            Debug.WriteLine("CrossplatformService service DoSomethingCrossplatform method called in UWP.");
        }
    }
}
