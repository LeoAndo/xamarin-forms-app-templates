using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        // OnAppearingをOverrideすることで、
        // Pageが表示される直前に動作をカスタマイズが可能！
        protected override async void OnAppearing()
        {
            Debug.WriteLine("OnAppearing!!");
            base.OnAppearing();
            await Task.Delay(10000); // splash表示時間

            //Transition to MainPage
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
