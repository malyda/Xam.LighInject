using System.Diagnostics;
using Xam.LightInject.Service.XFormsNative;
using Xam.LightInject.UWP.XFormsNative;
using Xamarin.Forms;

[assembly: Dependency(typeof(XFormsNativeImplementation))]
namespace Xam.LightInject.UWP.XFormsNative
{
    class XFormsNativeImplementation : IXFormsNative
    {
        public void DoSomethingXFormsNative()
        {
            Debug.WriteLine("XFormsNative service DoSomethingXFormsNative method called in UWP.");
        }
    }
}