using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AmyotrophicLateralSclerosisALS : ContentPage
    {
        public AmyotrophicLateralSclerosisALS()
        {
            Label header = new Label
            {
                Text = "Amyotrophic Lateral Sclerosis ALS",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Amyotrophic Lateral Sclerosis ALS",

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
