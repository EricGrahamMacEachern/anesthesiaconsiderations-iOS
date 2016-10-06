using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CleftLipAndPalate : ContentPage
    {
        public CleftLipAndPalate()
        {
            Label header = new Label
            {
                Text = "Cleft Lip And Palate",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cleft Lip And Palate",

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