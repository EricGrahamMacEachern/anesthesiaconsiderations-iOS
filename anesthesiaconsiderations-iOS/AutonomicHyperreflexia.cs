using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AutonomicHyperreflexia : ContentPage
    {
        public AutonomicHyperreflexia()
        {
            Label header = new Label
            {
                Text = "Autonomic Hyperreflexia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Autonomic Hyperreflexia",

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
