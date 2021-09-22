using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleApp.Models;
using Xamarin.Forms;

namespace SimpleApp
{
    public class FooViewModel
    {
        // ObservableCollection: 内部でINotifyPropertyChangedを実装している.
        public ObservableCollection<Person> Persons { get; private set; }
        public FooViewModel()
        {
            CreateCollection();
        }

        void CreateCollection()
        {
            var source = new List<Person>
            {

                new Person
                {
                    Name = "Yamada",
                    Details = "Details...........",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image1.png")
                },

                new Person
                {
                    Name = "Tanaka",
                    Details = "Details...........",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image2.png")
                },

                new Person
                {
                    Name = "Yoshida",
                    Details = "Details...........",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image3.png")
                },
            };
            Persons = new ObservableCollection<Person>(source);
        }
    }
}
