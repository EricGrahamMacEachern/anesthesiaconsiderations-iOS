using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DyspneaInPregnancy : ContentPage
    {
        public DyspneaInPregnancy()
        {
            Label header = new Label
            {
                Text = "Dyspnea In Pregnancy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Dyspnea In Pregnancy",

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