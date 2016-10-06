using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class GlycogenStorageDisorders : ContentPage
    {
        public GlycogenStorageDisorders()
        {
            Label header = new Label
            {
                Text = "Glycogen Storage Disorders",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Glycogen Storage Disorders",

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