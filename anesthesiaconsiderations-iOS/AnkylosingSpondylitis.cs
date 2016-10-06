using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AnkylosingSpondylitis : ContentPage
    {
        public AnkylosingSpondylitis()
        {
            Label header = new Label
            {
                Text = "Ankylosing Spondylitis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Ankylosing Spondylitis",

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