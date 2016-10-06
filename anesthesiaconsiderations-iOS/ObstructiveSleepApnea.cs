using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ObstructiveSleepApnea : ContentPage
    {
        public ObstructiveSleepApnea()
        {
            Label header = new Label
            {
                Text = "Obstructive SleepApnea",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Obstructive SleepApnea",

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