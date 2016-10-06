﻿using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class BetaBlockerOverdose : ContentPage
    {
        public BetaBlockerOverdose()
        {
            Label header = new Label
            {
                Text = "BetaBlocker Overdose",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "BetaBlocker Overdose",

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