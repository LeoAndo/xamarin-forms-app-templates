using SimpleApp.Pages;
using Xamarin.Forms;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE1NTc2QDMxMzkyZTMzMmUzMGx3TC91VENVdlR4Z0Z4VmZpWkFKMzlXbzNkaWIxVG1sTGZRS1YrQm5nSkk9");
            InitializeComponent();
            MainPage = new SplashPage();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
