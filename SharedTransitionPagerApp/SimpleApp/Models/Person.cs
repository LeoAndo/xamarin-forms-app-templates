using Xamarin.Forms;

namespace SimpleApp.Models
{
    public class Person
    {
        public Person()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public ImageSource ImageSource { get; set; }
        public Color CellBackgroundColor { get; set; }
    }
}
