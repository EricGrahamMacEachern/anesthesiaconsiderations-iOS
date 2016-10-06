using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AorticRegurgitation : ContentPage
    {
        public AorticRegurgitation()
        {
            Label header = new Label
            {
                Text = "Aortic Regurgitation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Aortic Regurgitation",

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
