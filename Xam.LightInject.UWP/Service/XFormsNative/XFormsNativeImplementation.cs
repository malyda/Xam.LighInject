using System.Diagnostics;
using Xam.LighInject.UWP.Service.XFormsNative;
using Xam.LightInject.Service.XFormsNative;
using Xamarin.Forms;

[assembly: Dependency(typeof(XFormsNativeImplementation))]
namespace Xam.LighInject.UWP.Service.XFormsNative
{
    class XFormsNativeImplementation : IXFormsNative
    {
        public void DoSomethingXFormsNative()
        {
            Debug.WriteLine("XFormsNative service DoSomethingXFormsNative method called in UWP.");
        }
    }
}