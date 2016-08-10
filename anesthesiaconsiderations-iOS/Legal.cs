using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Legal : ContentPage
    {
        public Legal()
        {
            Label header = new Label
            {
                Text = "Terms of Use",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label
            {
                Text = "Copyright/Licensing",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label2 = new Label
            {
                Text = "Consumer Content",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label3 = new Label
            {
                Text = "No Unlawful Use",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label4 = new Label
            {
                Text = "No Warranties",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label5 = new Label
            {
                Text = "Limitation of Liability",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label6 = new Label
            {
                Text = "Indemnification",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label7 = new Label
            {
                Text = "Modifications",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
           

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    label,
                    label2,
                    label3,
                    label4,
                    label5,
                    label6,
                    label7,
                   
                }
            };
        }
    }
}
