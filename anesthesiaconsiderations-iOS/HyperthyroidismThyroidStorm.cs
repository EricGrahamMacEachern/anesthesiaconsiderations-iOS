using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class HyperthyroidismThyroidStorm : ContentPage
    {
        public HyperthyroidismThyroidStorm()
        {
            Label header = new Label
            {
                Text = "Hyperthyroidism ThyroidStorm",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hyperthyroidism ThyroidStorm",

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