using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AtrialSeptalDefect : ContentPage
    {
        public AtrialSeptalDefect()
        {
            Label header = new Label
            {
                Text = "Atrial Septal Defect",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Atrial Septal Defect",

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
