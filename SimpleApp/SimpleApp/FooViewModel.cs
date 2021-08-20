using SimpleApp.Core.ViewModel;

namespace SimpleApp
{
    public class FooViewModel : ViewModelBase
    {
        string name;
        public FooViewModel()
        {
        }

        public string Name
        {
            set => SetProperty(ref name, value);
            get => name;
        }
    }
}
