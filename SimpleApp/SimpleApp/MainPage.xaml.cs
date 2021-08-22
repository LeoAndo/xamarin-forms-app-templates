using Xamarin.Forms;

namespace SimpleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void button1_Clicked(System.Object sender, System.EventArgs e)
        {
            bool showNavigationBar = switchShowNavBar.IsToggled;
            Navigation.PushAsync(new SubPage(name.Text.ToString(), showNavigationBar));
        }
    }
}
