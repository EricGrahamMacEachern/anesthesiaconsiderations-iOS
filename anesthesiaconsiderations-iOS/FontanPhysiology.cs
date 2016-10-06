using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class FontanPhysiology : ContentPage
    {
        public FontanPhysiology()
        {
            Label header = new Label
            {
                Text = "Fontan Physiology",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Fontan Physiology",

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
