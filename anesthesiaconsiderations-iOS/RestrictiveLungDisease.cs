using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class RestrictiveLungDisease : ContentPage
    {
        public RestrictiveLungDisease()
        {
            Label header = new Label
            {
                Text = "Pulmonary Embolism",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Pulmonary Embolism",

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