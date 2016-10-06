using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class NeurolepticMalignantSyndrome : ContentPage
    {
        public NeurolepticMalignantSyndrome()
        {
            Label header = new Label
            {
                Text = "Neuroleptic Malignant Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Neuroleptic Malignant Syndrome",

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