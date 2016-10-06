﻿using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PacemakersAndICDs : ContentPage
    {
        public PacemakersAndICDs()
        {
            Label header = new Label
            {
                Text = "Pacemakers & ICDs",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Pacemakers & ICDs",

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