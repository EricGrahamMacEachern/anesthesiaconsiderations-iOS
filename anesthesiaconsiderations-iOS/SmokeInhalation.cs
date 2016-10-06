using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SmokeInhalation : ContentPage
    {
        public SmokeInhalation()
        {
            Label header = new Label
            {
                Text = "Smoke Inhalation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Smoke Inhalation",

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