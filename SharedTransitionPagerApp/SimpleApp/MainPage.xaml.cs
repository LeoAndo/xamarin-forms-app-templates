using System;
using SimpleApp.Pages;
using Xamarin.Forms;
using Plugin.SharedTransitions;

namespace SimpleApp
{
    public partial class MainPage : ContentPage
    {
        private int currentPosition = 0;
        private FooViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new FooViewModel();
            BindingContext = vm;
        }

        void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            currentPosition = e.CurrentPosition;
            currentPos.Text = $"CurrentPageNo: {e.CurrentPosition + 1}";
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine($"Button_Clicked : {vm.Persons[currentPosition].Name}");
            SharedTransitionNavigationPage.SetBackgroundAnimation(this, BackgroundAnimation.Fade);
            SharedTransitionNavigationPage.SetTransitionDuration(this, 1000);
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(
                this, vm.Persons[currentPosition].Id.ToString());
            await Navigation.PushAsync(new DetailPage(vm.Persons[currentPosition]));
        }
    }
}
