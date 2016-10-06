using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MicrolaryngoscopyAndAirwayLaser : ContentPage
    {
        public MicrolaryngoscopyAndAirwayLaser()
        {
            Label header = new Label
            {
                Text = "Microlaryngospy & Airway Laser",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Microlaryngospy & Airway Laser",

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
