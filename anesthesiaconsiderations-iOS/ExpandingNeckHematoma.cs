using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ExpandingNeckHematoma : ContentPage
    {
        public ExpandingNeckHematoma()
        {
            Label header = new Label
            {
                Text = "Exapnding Neck Hematoma",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Exapnding Neck Hematoma",

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
