using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class EhlersDanlos : ContentPage
    {
        public EhlersDanlos()
        {
            Label header = new Label
            {
                Text = "Ehlers Danlos",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Ehlers Danlos",

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