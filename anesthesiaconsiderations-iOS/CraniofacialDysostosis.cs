using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CraniofacialDysostosis : ContentPage
    {
        public CraniofacialDysostosis()
        {
            Label header = new Label
            {
                Text = "Craniofacial Dysostosis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Craniofacial Dysostosis",

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