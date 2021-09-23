using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class SubPage : ContentPage
    {
        public SubPage(string name, bool showNavigationBar)
        {
            InitializeComponent();
            this.name.Text = name;
            NavigationPage.SetHasNavigationBar(this, showNavigationBar);
        }
    }
}
