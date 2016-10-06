using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class GuillainBarreSyndromeGBS : ContentPage
    {
        public GuillainBarreSyndromeGBS()
        {
            Label header = new Label
            {
                Text = "Guillain-Barre Syndrome (GBS)",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Guillain-Barre Syndrome (GBS)",

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
