using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MyotonicDystrophy : ContentPage
    {
        public MyotonicDystrophy()
        {
            Label header = new Label
            {
                Text = "Myotonic Dystrophy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Myotonic Dystrophy",

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
