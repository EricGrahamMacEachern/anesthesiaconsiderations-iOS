using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ExternalCephalicVersion : ContentPage
    {
        public ExternalCephalicVersion()
        {
            Label header = new Label
            {
                Text = "External Cephalic Version",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "External Cephalic Version",

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