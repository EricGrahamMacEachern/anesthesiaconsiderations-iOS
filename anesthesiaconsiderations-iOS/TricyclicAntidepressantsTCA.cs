using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TricyclicAntidepressantsTCA : ContentPage
    {
        public TricyclicAntidepressantsTCA()
        {
            Label header = new Label
            {
                Text = "Tricyclic Antidepressants (TCA)",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Tricyclic Antidepressants (TCA)",

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