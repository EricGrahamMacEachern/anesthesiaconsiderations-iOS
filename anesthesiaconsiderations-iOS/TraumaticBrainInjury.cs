using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TraumaticBrainInjury : ContentPage
    {
        public TraumaticBrainInjury()
        {
            Label header = new Label
            {
                Text = "Traumatic Brain Injury",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Traumatic Brain Injury",

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