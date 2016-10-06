using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AirwayAbscessAndInfection : ContentPage
    {
        public AirwayAbscessAndInfection()
        {
            Label header = new Label
            {
                Text = "Airway Abscess & Infection",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Airway Abscess & Infection",

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
