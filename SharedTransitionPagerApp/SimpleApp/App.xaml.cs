using Xamarin.Forms;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            Color barBackgroundColor = (Device.RuntimePlatform == Device.Android) ? Color.Black : Color.Orange;
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = barBackgroundColor
            };
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
