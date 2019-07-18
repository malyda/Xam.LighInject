using LightInject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xam.LightInject.Service
{
    public static class ServiceLocator
    {
        // make type abstract and change return values for this type in all methods
        static ServiceContainer serviceContainer; 

        public static ServiceContainer GetApplicationContainer()
        {
            if (serviceContainer == null) serviceContainer = new ServiceContainer();
            return serviceContainer;
        }

        public static void RegisterAsSingleton<TService, TImplementation>() where TImplementation : TService
        {
            GetApplicationContainer().Register<TService, TImplementation>(new PerContainerLifetime());
        }

        public static void Compile()
        {
            GetApplicationContainer().Compile();
        }

        public static T GetInstance<T>() where T : class
        {
           return GetApplicationContainer().GetInstance<T>();
        }
    }
}
