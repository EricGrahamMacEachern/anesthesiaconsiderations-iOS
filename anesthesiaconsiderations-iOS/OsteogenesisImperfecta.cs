using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class OsteogenesisImperfecta : ContentPage
    {
        public OsteogenesisImperfecta()
        {
            Label header = new Label
            {
                Text = "Osteogenesis Imperfecta",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Osteogenesis Imperfecta",

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