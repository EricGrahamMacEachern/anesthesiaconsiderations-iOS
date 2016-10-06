using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PosteriorFossaSurgery : ContentPage
    {
        public PosteriorFossaSurgery()
        {
            Label header = new Label
            {
                Text = "Posterior Fossa Surgery",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Posterior Fossa Surgery",

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