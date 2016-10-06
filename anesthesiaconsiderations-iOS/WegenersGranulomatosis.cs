using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class WegenersGranulomatosis : ContentPage
    {
        public WegenersGranulomatosis()
        {
            Label header = new Label
            {
                Text = "Wegeners Granulomatosis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Wegeners Granulomatosis",

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