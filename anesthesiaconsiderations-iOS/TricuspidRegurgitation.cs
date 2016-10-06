using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TricuspidRegurgitation : ContentPage
    {
        public TricuspidRegurgitation()
        {
            Label header = new Label
            {
                Text = "Tricuspid Regurgitation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Tricuspid Regurgitation",

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
