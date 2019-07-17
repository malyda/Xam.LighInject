﻿using System.Diagnostics;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.UWP.CrossplatformService
{
    public class CrossplatformServiceImplementation : ICrossplatformService
    {
        public void DoSomethingCrossplatform()
        {
            Debug.WriteLine("CrossplatformService service DoSomethingCrossplatform method called in UWP.");
        }
    }
}
