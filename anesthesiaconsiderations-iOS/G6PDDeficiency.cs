using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class G6PDDeficiency : ContentPage
    {
        public G6PDDeficiency()
        {
            Label header = new Label
            {
                Text = "G6PD Deficiency",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "G6PD Deficiency",

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
