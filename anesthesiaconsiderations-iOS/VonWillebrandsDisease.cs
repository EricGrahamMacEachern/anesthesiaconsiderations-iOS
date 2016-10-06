using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class VonWillebrandsDisease : ContentPage
    {
        public VonWillebrandsDisease()
        {
            Label header = new Label
            {
                Text = "Von Willebrand's Disease",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Von Willebrand's Disease",

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
