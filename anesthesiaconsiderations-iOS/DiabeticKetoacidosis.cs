﻿using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DiabeticKetoacidosis : ContentPage
    {
        public DiabeticKetoacidosis()
        {
            Label header = new Label
            {
                Text = "Diabetic Ketoacidosis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Diabetic Ketoacidosis",

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