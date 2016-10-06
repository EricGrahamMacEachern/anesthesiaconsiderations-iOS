using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ElectroconvulsiveTherapyECT : ContentPage
    {
        public ElectroconvulsiveTherapyECT()
        {
            Label header = new Label
            {
                Text = "Electroconvulsive Therapy (ECT)",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Electroconvulsive Therapy (ECT)",

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