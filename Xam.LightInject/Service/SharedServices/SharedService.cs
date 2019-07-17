using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Xam.LightInject.Service.SharedServices
{
    class SharedService : ISharedService
    {
        public void DoSomething()
        {
            Debug.WriteLine("Shared service DoSomething method called.");
        }
    }
}
