using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TracheoesophagealFistula : ContentPage
    {
        public TracheoesophagealFistula()
        {
            Label header = new Label
            {
                Text = "Tracheoesophageal Fistula ",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Tracheoesophageal Fistula ",

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