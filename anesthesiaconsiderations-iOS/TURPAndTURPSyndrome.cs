using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TURPAndTURPSyndrome : ContentPage
    {
        public TURPAndTURPSyndrome()
        {
            Label header = new Label
            {
                Text = "TURP & TURP Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "TURP & TURP Syndrome",

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