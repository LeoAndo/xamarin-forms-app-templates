using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        private Regex EMAIL_ADDRESS = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        public LoginPage()
        {
            InitializeComponent();
            entryId.TextChanged += (sender, e) =>
            {
                inputLayoutId.HasError = false;
                setEnableLoginButton();
                Console.WriteLine($"Length: {entryId.Text.Length}");
            };
            entryPassword.TextChanged += (sender, e) =>
            {
                inputLayoutPassword.HasError = false;
                setEnableLoginButton();
            };
            buttonLogin.Clicked += async (sender, e) =>
            {
                if (validate())
                {
                    // TODO 2秒間ローディング
                    progress.IsIndeterminate = true;
                    progressLayout.IsVisible = true;
                    await Task.Delay(2000);
                    progressLayout.IsVisible = false;
                    progress.IsIndeterminate = false;
                    // Main画面に遷移する
                    Brush barBackgroundColor = (Device.RuntimePlatform == Device.Android) ? Brush.Black : Brush.Orange;
                    App.Current.MainPage = new SharedTransitionNavigationPage(new CardsPage())
                    {
                        BarBackground = barBackgroundColor
                    };
                }
            };
        }

        private void setEnableLoginButton()
        {
            if (entryId.Text == null || entryPassword.Text == null)
            {
                buttonLogin.IsEnabled = false;
                return;
            }
            bool isEnable = entryId.Text.Length > 0 &&
                entryPassword.Text.Length > 0;
            buttonLogin.IsEnabled = isEnable;
        }
        private bool validate()
        {
            bool isValid = true;
            if (!isUserIdValid(entryId.Text))
            {
                isValid = false;
                inputLayoutId.HasError = true;
            }
            if (!isPasswordValid(entryPassword.Text))
            {
                isValid = false;
                inputLayoutPassword.HasError = true;
            }

            return isValid;
        }
        private bool isUserIdValid(string userId)
        {
            return EMAIL_ADDRESS.IsMatch(userId);
        }
        private bool isPasswordValid(string password)
        {
            return password.Length > 7;
        }
    }
}