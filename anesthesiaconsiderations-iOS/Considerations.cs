using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Considerations : ContentPage
    {
        public Considerations()
        {
            Label header = new Label
            {
                Text = "Considerations",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label
            {
                Text = "Airway",
                    
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label2 = new Label
            {
                Text = "Cardiac",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label3 = new Label
            {
                Text = "Critical Care",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label4 = new Label
            {
                Text = "Endocrinology",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label5 = new Label
            {
                Text = "Hematology",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label6 = new Label
            {
                Text = "Hepatic",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label7 = new Label
            {
                Text = "Neuroanesthesia",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label8 = new Label
            {
                Text = "Obstetrics",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label9 = new Label
            {
                Text = "Pediatrics",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label10 = new Label
            {
                Text = "Psychiatric",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label11 = new Label
            {
                Text = "Rare Co-existing Disease",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label12 = new Label
            {
                Text = "Renal",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label13 = new Label
            {
                Text = "Respiratory & Thoracics",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label14 = new Label
            {
                Text = "Skin & Musculoskeletal",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label15 = new Label
            {
                Text = "Toxicities",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label16 = new Label
            {
                Text = "Vascular",

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
                    label8,
                    label9,
                    label10,
                    label11,
                    label12,
                    label13,
                    label14,
                    label15,
                    label16,
                }
            };
        }
    }
}
