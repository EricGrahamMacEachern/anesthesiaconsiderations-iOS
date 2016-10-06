using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SystemicLupusErythematosusSLE : ContentPage
    {
        public SystemicLupusErythematosusSLE()
        {
            Label header = new Label
            {
                Text = "Systemic Lupus Erythematosus (SLE)",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Systemic Lupus Erythematosus (SLE)",

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