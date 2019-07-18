
using System;
using System.IO;
using System.Text;
using Windows.System.Profile;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.UWP
{
    class DeviceIdentificationImplementation : IDeviceIdentification
    {
        public string GetIMEI()
        {
            return $"IMEI is not available on UWP";
        }

        public string GetHardwareID()
        {
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.System.Profile.HardwareIdentification"))
            {
                var token = HardwareIdentification.GetPackageSpecificToken(null);
                var hardwareId = token.Id;
                var dataReader = Windows.Storage.Streams.DataReader.FromBuffer(hardwareId);

                byte[] bytes = new byte[hardwareId.Length];
                dataReader.ReadBytes(bytes);

                return $"Hardware ID: {BitConverter.ToString(bytes).Replace("-", "")}";
            }

            return $"Hardware ID is not presented on device";
        }
    }
}