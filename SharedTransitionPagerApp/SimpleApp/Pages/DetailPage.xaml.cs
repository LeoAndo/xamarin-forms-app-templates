using SimpleApp.Models;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Person person)
        {
            InitializeComponent();
            lblA.Text = person.Name;
            imageA.Source = person.ImageSource;
            lblDetail.Text = person.Details;
        }
    }
}
