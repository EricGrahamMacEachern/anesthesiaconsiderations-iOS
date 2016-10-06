using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AcuteLeukemia : ContentPage
    {
        public AcuteLeukemia()
        {
            Label header = new Label
            {
                Text = "Acute Leukemia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Acute Leukemia",

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
