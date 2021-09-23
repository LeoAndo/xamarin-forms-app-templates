using SimpleApp.Pages;
using Xamarin.Forms;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // MainPage = new NavigationPage(new MainPage());
            MainPage = new SplashPage(); // NavigationPageで囲むとツールバーが出てしまう。
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
