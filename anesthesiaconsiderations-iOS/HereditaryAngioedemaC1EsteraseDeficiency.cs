using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class HereditaryAngioedemaC1EsteraseDeficiency : ContentPage
    {
        public HereditaryAngioedemaC1EsteraseDeficiency()
        {
            Label header = new Label
            {
                Text = "Hereditary Angioedema C1 Esterase Deficiency",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hereditary Angioedema C1 Esterase Deficiency",

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