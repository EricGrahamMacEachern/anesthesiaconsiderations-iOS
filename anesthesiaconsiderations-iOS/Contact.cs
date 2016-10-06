using System;
using Xamarin.Forms;


    class Contact : ContentPage
    {
        public Contact()
        {
            Label header = new Label
            {
                Text = "Contact",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Button emailButton = new Button { Text = "Website Contact" };
            emailButton.Clicked += (sender, e) =>
            {
                Device.OpenUri(new Uri("http://www.anesthesiaconsiderations.com/"));
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    emailButton
                }
            };
        }
    }

