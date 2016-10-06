using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PulmonaryHypertension : ContentPage
    {
        public PulmonaryHypertension()
        {
            Label header = new Label
            {
                Text = "Pulmonary Hypertension",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Pulmonary Hypertension",

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
