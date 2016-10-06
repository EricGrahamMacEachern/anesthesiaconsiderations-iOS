using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Mediastinoscopy : ContentPage
    {
        public Mediastinoscopy()
        {
            Label header = new Label
            {
                Text = "Mediastinoscopy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Mediastinoscopy",

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