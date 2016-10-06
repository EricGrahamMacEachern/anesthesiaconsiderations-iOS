using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PostpartumHemorrhage : ContentPage
    {
        public PostpartumHemorrhage()
        {
            Label header = new Label
            {
                Text = "Postpartum Hemorrhage",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Postpartum Hemorrhage",

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