using System.Diagnostics;
using Xam.LighInject.Service.XFormsNative;
using Xam.LighInject.UWP.XFormsNative;
using Xamarin.Forms;

[assembly: Dependency(typeof(XFormsNativeImplementation))]
namespace Xam.LighInject.UWP.XFormsNative
{
    class XFormsNativeImplementation : IXFormsNative
    {
        public void DoSomethingXFormsNative()
        {
            Debug.WriteLine("XFormsNative service DoSomethingXFormsNative method called in UWP.");
        }
    }
}