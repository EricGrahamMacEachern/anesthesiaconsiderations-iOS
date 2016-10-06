using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PlacentalAbruption : ContentPage
    {
        public PlacentalAbruption()
        {
            Label header = new Label
            {
                Text = "Placental Abruption",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Placental Abruption",

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