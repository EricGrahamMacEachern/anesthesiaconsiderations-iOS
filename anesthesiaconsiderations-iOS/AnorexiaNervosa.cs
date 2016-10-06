using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AnorexiaNervosa : ContentPage
    {
        public AnorexiaNervosa()
        {
            Label header = new Label
            {
                Text = "Anorexia Nervosa",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Anorexia Nervosa",

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