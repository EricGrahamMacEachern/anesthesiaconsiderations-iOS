using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SubarachnoidHemorrhage : ContentPage
    {
        public SubarachnoidHemorrhage()
        {
            Label header = new Label
            {
                Text = "Subarachnoid Hemorrhage",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Subarachnoid Hemorrhage",

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