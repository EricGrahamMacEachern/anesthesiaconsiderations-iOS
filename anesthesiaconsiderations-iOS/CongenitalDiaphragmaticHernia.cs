using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CongenitalDiaphragmaticHernia : ContentPage
    {
        public CongenitalDiaphragmaticHernia()
        {
            Label header = new Label
            {
                Text = "Congenital Diaphragmatic Hernia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Congenital Diaphragmatic Hernia",

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