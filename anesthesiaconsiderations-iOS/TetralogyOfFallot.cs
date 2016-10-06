using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TetralogyOfFallot : ContentPage
    {
        public TetralogyOfFallot()
        {
            Label header = new Label
            {
                Text = "Tetralogy of Fallout",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Tetralogy of Fallout",

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