using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AdultCongenitalHeartDisease : ContentPage
    {
        public AdultCongenitalHeartDisease()
        {
            Label header = new Label
            {
                Text = "Adult Congenital Heart Disease",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Adult Congenital Heart Disease",

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
