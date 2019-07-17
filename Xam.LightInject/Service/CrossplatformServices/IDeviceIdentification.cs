using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xam.LightInject.Service.CrossplatformServices
{
    public interface IDeviceIdentification
    {
        string GetIMEI();
        string GetHardwareID();
    }
}
