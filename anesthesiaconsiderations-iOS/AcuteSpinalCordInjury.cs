using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AcuteSpinalCordInjury : ContentPage
    {
        public AcuteSpinalCordInjury()
        {
            Label header = new Label
            {
                Text = "Acute Spinal Cord Injury",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Acute Spinal Cord Injury",

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
