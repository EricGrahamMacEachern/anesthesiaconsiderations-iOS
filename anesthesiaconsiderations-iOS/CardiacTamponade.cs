using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CardiacTamponade : ContentPage
    {
        public CardiacTamponade()
        {
            Label header = new Label
            {
                Text = "Cardiac Tamponade",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cardiac Tamponade",

                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                }
            };



            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    scrollView,
                }
            };
        }
    }
}
