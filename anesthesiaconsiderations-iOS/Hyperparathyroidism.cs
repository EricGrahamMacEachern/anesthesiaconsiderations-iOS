using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hyperparathyroidism : ContentPage
    {
        public Hyperparathyroidism()
        {
            Label header = new Label
            {
                Text = "Hyperparathyroidism",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hyperparathyroidism",

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