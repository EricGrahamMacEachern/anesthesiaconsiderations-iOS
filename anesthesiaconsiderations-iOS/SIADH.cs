using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SIADH : ContentPage
    {
        public SIADH()
        {
            Label header = new Label
            {
                Text = "SIADH",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "SIADH",

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