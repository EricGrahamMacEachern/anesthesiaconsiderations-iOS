using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CervicalCerclage : ContentPage
    {
        public CervicalCerclage()
        {
            Label header = new Label
            {
                Text = "Cervical Cerclage",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Cervical Cerclage",

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