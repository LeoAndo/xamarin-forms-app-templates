using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleApp.Models;
using Xamarin.Forms;

namespace SimpleApp
{
    public class FooViewModel
    {
        // ObservableCollection: 内部でINotifyCollectionChangedを実装している.
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
                    Id = 1,
                    Name = "Yamada",
                    Details = "DetailsAAAAAAAAAAAAAAAAAABBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBCCCCCCCCCCCCCCC",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image1.png"),
                    CellBackgroundColor = Color.FromHex("#bbdefb"),
                },

                new Person
                {
                    Id = 2,
                    Name = "Tanaka",
                    Details = "Details...........",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image2.png"),
                    CellBackgroundColor = Color.FromHex("#c5cae9"),
                },

                new Person
                {
                    Id = 3,
                    Name = "Yoshida",
                    Details = "Details...........",
                    ImageSource = ImageSource.FromResource("SimpleApp.Images.sample_image3.png"),
                    CellBackgroundColor = Color.FromHex("#b2dfdb"),
                },
            };
            Persons = new ObservableCollection<Person>(source);
        }
    }
}
