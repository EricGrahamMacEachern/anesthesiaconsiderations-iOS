using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AtrialFibrillation : ContentPage
    {
        public AtrialFibrillation()
        {
            Label header = new Label
            {
                Text = "Atrial Fibrillation",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Atrial Fibrillation",

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
