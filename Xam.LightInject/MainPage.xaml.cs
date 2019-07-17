

using LightInject;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xam.LightInject.Service.CrossplatformServices;
using Xamarin.Forms;

namespace Xam.LightInject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ServiceContainer container;
        public MainPage(ServiceContainer container)
        {
            InitializeComponent();
            this.container = container;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LogDeviceIdetification();
        }

        public async Task LogDeviceIdetification()
        {
            var deviceIdentification = container.GetInstance<IDeviceIdentification>();
            Debug.WriteLine(deviceIdentification.GetIMEI());

            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Phone);


            if (status != PermissionStatus.Granted)
            {
               // await DisplayAlert("Need access phone state", "Gonna need access phone state", "OK");
                status = (await CrossPermissions.Current.RequestPermissionsAsync(Permission.Phone))[Permission.Phone];
            }

            if (status == PermissionStatus.Granted)
            {
                Debug.WriteLine(deviceIdentification.GetHardwareID());
            }
            else if (status != PermissionStatus.Unknown)
            {
                Debug.WriteLine("Could not get Serial number");
            }

            return;
        }
    }
}
