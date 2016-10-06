using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PeriodicParalysis : ContentPage
    {
        public PeriodicParalysis()
        {
            Label header = new Label
            {
                Text = "Periodic Paralysis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Periodic Paralysis",

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