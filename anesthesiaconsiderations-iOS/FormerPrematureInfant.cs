using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class FormerPrematureInfant : ContentPage
    {
        public FormerPrematureInfant()
        {
            Label header = new Label
            {
                Text = "Former Premature Infant",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Former Premature Infant",

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