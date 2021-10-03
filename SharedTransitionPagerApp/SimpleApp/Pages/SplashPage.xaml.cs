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
            //Transition to MainPage
            Brush barBackgroundColor = (Device.RuntimePlatform == Device.Android) ? Brush.Black : Brush.Orange;
            App.Current.MainPage = new SharedTransitionNavigationPage(new MainPage())
            {
                BarBackground = barBackgroundColor
            };
        }
    }
}
