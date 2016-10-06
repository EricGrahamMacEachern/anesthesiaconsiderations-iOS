using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class BullousLungDisease : ContentPage
    {
        public BullousLungDisease()
        {
            Label header = new Label
            {
                Text = "BullousLung Disease",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "BullousLung Disease",

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