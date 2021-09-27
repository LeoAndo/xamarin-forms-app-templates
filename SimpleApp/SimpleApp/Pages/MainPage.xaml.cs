using System;
using Xamarin.Forms;

namespace SimpleApp.Pages
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

        // ContentPage がレイアウトが表示される直前に実行される
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Console.WriteLine("OnAppearing");
        }

        // アプリ内のページから移動することによってページが表示されなくなったときに呼び出される
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Console.WriteLine("OnDisappearing");
        }
    }
}
