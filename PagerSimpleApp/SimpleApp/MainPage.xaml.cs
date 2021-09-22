using Xamarin.Forms;

namespace SimpleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void CarouselView_PositionChanged(System.Object sender, Xamarin.Forms.PositionChangedEventArgs e)
        {
            currentPos.Text = $"CurrentPageNo: {e.CurrentPosition + 1}";
        }
    }
}
