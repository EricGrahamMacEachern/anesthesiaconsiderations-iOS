using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ArnoldChiariMalformation : ContentPage
    {
        public ArnoldChiariMalformation()
        {
            Label header = new Label
            {
                Text = "Arnold Chiari Malformation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Arnold Chiari Malformation",

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
