using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AirwayForeignBody : ContentPage
    {
        public AirwayForeignBody()
        {
            Label header = new Label
            {
                Text = "Airway Foreign Body",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Airway Foreign Body",

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