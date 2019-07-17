using Android.OS;
using Xam.LightInject.Service.CrossplatformServices;

namespace Xam.LightInject.Droid
{
    class DeviceIdentificationImplementation : IDeviceIdentification
    {
        public string GetIMEI()
        {
            string identification = $"IMEI: {Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId)}";
            return identification;
        }

        public string GetSerialNumber()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                return $"SerialNumber: {Build.GetSerial()}";
            }
            else
            {
                return $"SerialNumber: {Build.Serial}";
            }
        }
    }
}