using System.Diagnostics;
using Xam.LightInject.Droid.XFormsNative;
using Xam.LightInject.Service.XFormsNative;
using Xamarin.Forms;

[assembly: Dependency(typeof(XFormsNativeImplementation))]
namespace Xam.LightInject.Droid.XFormsNative
{
    class XFormsNativeImplementation : IXFormsNative
    {
        public void DoSomethingXFormsNative()
        {
            Debug.WriteLine("XFormsNative service DoSomethingXFormsNative method called in Android.");
        }
    }
}