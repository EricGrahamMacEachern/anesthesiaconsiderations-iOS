using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Cardiomyopathies : ContentPage
    {
        public Cardiomyopathies()
        {
            Label header = new Label
            {
                Text = "Cardiomyopathies",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cardiomyopathies",

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
