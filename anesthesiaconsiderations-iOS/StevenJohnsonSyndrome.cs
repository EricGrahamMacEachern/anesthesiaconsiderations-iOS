using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class StevenJohnsonSyndrome : ContentPage
    {
        public StevenJohnsonSyndrome()
        {
            Label header = new Label
            {
                Text = "Steven Johnson's Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Steven Johnson's Syndrome",

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