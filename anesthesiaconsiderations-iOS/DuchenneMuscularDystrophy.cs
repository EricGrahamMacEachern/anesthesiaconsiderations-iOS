using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DuchenneMuscularDystrophy : ContentPage
    {
        public DuchenneMuscularDystrophy()
        {
            Label header = new Label
            {
                Text = "Duchenne Muscular Dystrophy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Duchenne Muscular Dystrophy",

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