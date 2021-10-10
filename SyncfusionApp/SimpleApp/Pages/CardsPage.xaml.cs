using System;
using Xamarin.Forms;

namespace SimpleApp.Pages
{
    public partial class CardsPage : ContentPage
    {
        private int tabIndex = 0;
        public CardsPage()
        {
            InitializeComponent();
            // event hook.
            cardLayout.CardTapped += (sender, e) =>
            {
                Console.WriteLine($"index: {tabIndex}");
                Navigation.PushAsync(new CardDetailPage());
            };
            cardLayout.VisibleCardIndexChanged += (sender, e) =>
            {
                if (e.NewCard != null)
                {
                    tabIndex = e.NewCard.TabIndex;
                    Console.WriteLine($"NewCard TabIndex is {e.NewCard.TabIndex}");
                }
            };
        }
    }
}
