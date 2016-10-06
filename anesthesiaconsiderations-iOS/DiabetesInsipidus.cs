using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DiabetesInsipidus : ContentPage
    {
        public DiabetesInsipidus()
        {
            Label header = new Label
            {
                Text = "Diabetes Insipidus",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Diabetes Insipidus",

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