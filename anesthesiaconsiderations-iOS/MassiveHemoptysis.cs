using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MassiveHemoptysis : ContentPage
    {
        public MassiveHemoptysis()
        {
            Label header = new Label
            {
                Text = "Massive Hemoptysis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Massive Hemoptysis",

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