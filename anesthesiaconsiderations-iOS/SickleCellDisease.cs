using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SickleCellDisease : ContentPage
    {
        public SickleCellDisease()
        {
            Label header = new Label
            {
                Text = "Sickle Cell Disease",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Sickle Cell Disease",

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
