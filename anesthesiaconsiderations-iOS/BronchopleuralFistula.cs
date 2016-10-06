using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class BronchopleuralFistula : ContentPage
    {
        public BronchopleuralFistula()
        {
            Label header = new Label
            {
                Text = "Bronchopleural Fistula",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Bronchopleural Fistula",

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