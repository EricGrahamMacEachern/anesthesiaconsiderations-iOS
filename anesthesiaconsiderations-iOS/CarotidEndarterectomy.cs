using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CarotidEndarterectomy : ContentPage
    {
        public CarotidEndarterectomy()
        {
            Label header = new Label
            {
                Text = "Carotid Endarterectomy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Carotid Endarterectomy",

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