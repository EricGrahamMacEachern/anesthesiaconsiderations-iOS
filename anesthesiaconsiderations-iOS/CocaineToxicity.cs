using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CocaineToxicity : ContentPage
    {
        public CocaineToxicity()
        {
            Label header = new Label
            {
                Text = "Cocaine Toxicity",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cocaine Toxicity",

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