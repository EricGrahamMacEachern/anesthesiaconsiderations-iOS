using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PenetratingNeckInjuries : ContentPage
    {
        public PenetratingNeckInjuries()
        {
            Label header = new Label
            {
                Text = "Penetrating Neck Injuries",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Penetrating Neck Injuries",

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
