using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CroupLaryngotracheobronchitis : ContentPage
    {
        public CroupLaryngotracheobronchitis()
        {
            Label header = new Label
            {
                Text = "Croup Laryngotracheobronchitis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Croup Laryngotracheobronchitis",

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