using System;
using System.Threading.Tasks;
using Syncfusion.XForms.ProgressBar;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class CardDetailPage : ContentPage
    {
        public CardDetailPage()
        {
            InitializeComponent();
            StepView[] stepViews = { stepView1, stepView2, stepView3, stepView4 };

            // event
            buttonStepResetStatus.Clicked += (sender, e) =>
            {
                foreach (StepView view in stepViews)
                {
                    view.Status = StepStatus.NotStarted;
                }
            };
        }

        async void SfStepProgressBar_StepTapped(object sender, StepTappedEventArgs e)
        {
            Console.WriteLine($"Index: {e.Index}");
            e.Item.Status = StepStatus.Completed;
            var title = "";
            var message = "";
            switch (e.Index)
            {
                case 0:
                    title = "Title1";
                    message = "Message1";
                    break;
                case 1:
                    title = "Title2";
                    message = "Message2";
                    break;
                case 2:
                    title = "Title3";
                    message = "Message3";
                    break;
                case 3:
                    title = "Title4";
                    message = "Message4";
                    break;
            }
            await Task.Delay(2000);
            await DisplayAlert(title, message, "OK");
        }
    }
}
