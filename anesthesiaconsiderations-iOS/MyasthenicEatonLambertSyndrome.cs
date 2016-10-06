using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MyasthenicEatonLambertSyndrome : ContentPage
    {
        public MyasthenicEatonLambertSyndrome()
        {
            Label header = new Label
            {
                Text = "Myasthenic (Eaton-Lambert) Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Myasthenic (Eaton-Lambert) Syndrome",

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
