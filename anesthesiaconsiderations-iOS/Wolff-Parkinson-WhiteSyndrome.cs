using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class WolffParkinsonWhiteSyndrome : ContentPage
    {
        public WolffParkinsonWhiteSyndrome()
        {
            Label header = new Label
            {
                Text = "Wolff-Parkinson-White Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Wolff-Parkinson-White Syndrome",

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
