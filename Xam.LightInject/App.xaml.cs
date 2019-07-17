using LightInject;
using System;

using Xamarin.Forms;

namespace Xam.LightInject
{
    public partial class App : Application
    {
        // LightInject
        public ServiceContainer container;

        public App()
        {
            InitializeComponent();

            /*

                // standard
                container.Register<ISharedService, SharedService>();

                var sharedServiceInstance = container.GetInstance<ISharedService>();
                sharedServiceInstance
                    .DoSomething();




                  // crossplatform via assembly scanning
                var assemblies = new List<Assembly>(AppDomain.CurrentDomain.GetAssemblies());

                var currentAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                var targetAssemblyName = $"{currentAssemblyName}.{Device.RuntimePlatform}";

                var platform = assemblies.Where(s => s.FullName.Contains(targetAssemblyName)).ToList();
                container.RegisterAssembly(platform.FirstOrDefault() );

 


                // Xamarin.Forms native solution
                DependencyService.Get<IXFormsNative>()
                    .DoSomethingXFormsNative();
            */

           
        }

        public void RegisterService(Type type, Type implementation)
        {
            if (container == null) container = new ServiceContainer();
            container.Register(type, implementation);
        }
        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new MainPage(container);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
           
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
