using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CerebralPalsy : ContentPage
    {
        public CerebralPalsy()
        {
            Label header = new Label
            {
                Text = "Cerebral Palsy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cerebral Palsy",

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