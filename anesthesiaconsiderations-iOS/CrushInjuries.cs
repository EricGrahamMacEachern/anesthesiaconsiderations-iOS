﻿using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class CrushInjuries : ContentPage
    {
        public CrushInjuries()
        {
            Label header = new Label
            {
                Text = "BurnsCrush Injuries",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "BurnsCrush Injuries",

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