using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DisseminatedIntravascularCoagulationDIC : ContentPage
    {
        public DisseminatedIntravascularCoagulationDIC()
        {
            Label header = new Label
            {
                Text = "Disseminated Intravascular Coagulation (DIC)",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Disseminated Intravascular Coagulation (DIC)",

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
