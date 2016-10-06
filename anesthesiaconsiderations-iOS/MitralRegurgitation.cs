using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MitralRegurgitation : ContentPage
    {
        public MitralRegurgitation()
        {
            Label header = new Label
            {
                Text = "Mitral Regurgitation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Mitral Regurgitation",

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
