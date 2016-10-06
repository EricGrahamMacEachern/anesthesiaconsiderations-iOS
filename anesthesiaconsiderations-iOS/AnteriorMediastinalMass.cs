using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AnteriorMediastinalMass : ContentPage
    {
        public AnteriorMediastinalMass()
        {
            Label header = new Label
            {
                Text = "Anterior Mediastinal Mass",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Anterior Mediastinal Mass",

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