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
            // splash表示時間 (awaitしてる時間)
            await animationView.ScaleTo(1, 2000); // 2秒間　通常の倍率でViewを表示
            await animationView.ScaleTo(0, 1000); // 1秒かけて倍率を0にする

            //Transition to MainPage
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
