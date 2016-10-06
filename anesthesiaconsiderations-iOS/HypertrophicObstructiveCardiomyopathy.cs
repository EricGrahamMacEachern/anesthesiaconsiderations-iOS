using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class HypertrophicObstructiveCardiomyopathy : ContentPage
    {
        public HypertrophicObstructiveCardiomyopathy()
        {
            Label header = new Label
            {
                Text = "Hypertrophic Obstructive Cardiomyopathy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hypertrophic Obstructive Cardiomyopathy",

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
