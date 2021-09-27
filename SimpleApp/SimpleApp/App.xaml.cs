using System;
using SimpleApp.Pages;
using Xamarin.Forms;

namespace SimpleApp
{
    // Single Activityなので、このクラスはActivityと考えていい.
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // MainPage = new NavigationPage(new MainPage());
            MainPage = new SplashPage(); // NavigationPageで囲むとツールバーが出てしまう。
        }

        // アプリケーションの起動時に呼び出される
        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        // アプリケーションがバックグラウンドに移行したときに呼び出される
        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        // アプリケーションがバックグラウンドから再開したときに呼び出される
        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
        // アプリケーションの終了イベントを受け取れない.
    }
}
