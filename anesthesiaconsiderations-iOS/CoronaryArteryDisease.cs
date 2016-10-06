using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CoronaryArteryDisease : ContentPage
    {
        public CoronaryArteryDisease()
        {
            Label header = new Label
            {
                Text = "Coronary Artery Disease",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Coronary Artery Disease",

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
