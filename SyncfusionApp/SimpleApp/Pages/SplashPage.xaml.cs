using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        void animationView_OnFinishedAnimation(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}
