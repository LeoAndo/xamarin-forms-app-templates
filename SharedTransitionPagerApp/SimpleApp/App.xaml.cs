﻿using Plugin.SharedTransitions;
using SimpleApp.Pages;
using Xamarin.Forms;

namespace SimpleApp
{
    public partial class App : Application
    {
        public App()
        {
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
