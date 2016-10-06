using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AdrenocorticalInsufficiency : ContentPage
    {
        public AdrenocorticalInsufficiency()
        {
            Label header = new Label
            {
                Text = "Adrenocortical Insufficiency",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Adrenocortical Insufficiency",

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