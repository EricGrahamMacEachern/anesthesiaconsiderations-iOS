using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ChronicRenalFailure : ContentPage
    {
        public ChronicRenalFailure()
        {
            Label header = new Label
            {
                Text = "Chronic Renal Failure",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Chronic Renal Failure",

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