using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TransplantedHeart : ContentPage
    {
        public TransplantedHeart()
        {
            Label header = new Label
            {
                Text = "Transplanted Heart",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Transplanted Heart",

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
