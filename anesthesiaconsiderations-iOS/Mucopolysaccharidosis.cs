using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Mucopolysaccharidosis : ContentPage
    {
        public Mucopolysaccharidosis()
        {
            Label header = new Label
            {
                Text = "Mucopolysaccharidosis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Mucopolysaccharidosis",

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