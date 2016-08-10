using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Emergencies : ContentPage
    {
        public Emergencies()
        {
            Label header = new Label
            {
                Text = "Airway Fire",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label
            {
                Text = "Anaphylaxis",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label2 = new Label
            {
                Text = "Bronchospasm",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label3 = new Label
            {
                Text = "Delayed Emergence",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label4 = new Label
            {
                Text = "Extravasation Injuries",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label5 = new Label
            {
                Text = "Fat Embolism",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label6 = new Label
            {
                Text = "Hypertension",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label7 = new Label
            {
                Text = "Hypoglycemia",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label8 = new Label
            {
                Text = "Hypotension",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label9 = new Label
            {
                Text = "Hypoxemia",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label10 = new Label
            {
                Text = "Increased Airway Pressure",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label11 = new Label
            {
                Text = "Local Anesthetic Toxicity",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label12 = new Label
            {
                Text = "Malignant Hyperthermia",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label13 = new Label
            {
                Text = "Perioperative MI",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label14 = new Label
            {
                Text = "Seizure",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label15 = new Label
            {
                Text = "Postoperative Visual Loss",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label16 = new Label
            {
                Text = "Total Spinal",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label17 = new Label
            {
                Text = "Transfusion Reactions",

                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label18 = new Label
            {
                Text = "Venous Air Embolism",

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
                    label17,
                    label18,
                }
            };
        }
    }
}
