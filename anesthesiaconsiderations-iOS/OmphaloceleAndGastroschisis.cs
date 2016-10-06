using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class OmphaloceleAndGastroschisis : ContentPage
    {
        public OmphaloceleAndGastroschisis()
        {
            Label header = new Label
            {
                Text = "Omphalocele & Gastroschisis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Necrotizing Enterocolitis",

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