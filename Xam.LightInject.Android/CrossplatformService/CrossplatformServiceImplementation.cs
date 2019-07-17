using System.Diagnostics;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.Droid.CrossplatformService
{
    public class CrossplatformServiceImplementation : ICrossplatformService
    {
        public void DoSomethingCrossplatform()
        {
            Debug.WriteLine("CrossplatformService service DoSomethingCrossplatform method called in Android.");
        }
    }
}
