using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AorticStenosis : ContentPage
    {
        public AorticStenosis()
        {
            Label header = new Label
            {
                Text = "Aortic Stenosis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Aortic Stenosis",

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
