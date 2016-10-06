using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PeripartumCardiacArrest : ContentPage
    {
        public PeripartumCardiacArrest()
        {
            Label header = new Label
            {
                Text = "Peripartum Cardiac Arrest",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Peripartum Cardiac Arrest",

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