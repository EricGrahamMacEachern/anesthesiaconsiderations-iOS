using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Pheochromocytoma : ContentPage
    {
        public Pheochromocytoma()
        {
            Label header = new Label
            {
                Text = "Pheochromocytoma",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Pheochromocytoma",

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