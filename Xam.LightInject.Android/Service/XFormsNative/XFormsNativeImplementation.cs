using System.Diagnostics;
using Xam.LighInject.Droid.Service.XFormsNative;
using Xam.LightInject.Service.XFormsNative;
using Xamarin.Forms;

[assembly: Dependency(typeof(XFormsNativeImplementation))]
namespace Xam.LighInject.Droid.Service.XFormsNative
{
    class XFormsNativeImplementation : IXFormsNative
    {
        public void DoSomethingXFormsNative()
        {
            Debug.WriteLine("XFormsNative service DoSomethingXFormsNative method called in Android.");
        }
    }
}