using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class InfectiveEndocarditisProphylaxis : ContentPage
    {
        public InfectiveEndocarditisProphylaxis()
        {
            Label header = new Label
            {
                Text = "Infective Endocarditis Prophylaxis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Infective Endocarditis Prophylaxis",

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
