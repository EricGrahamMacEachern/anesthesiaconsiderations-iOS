using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hypoglycemia : ContentPage
    {
        public Hypoglycemia()
        {
            Label header = new Label
            {
                Text = "Hypoglycemia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Signs" +

"Sympathetic system activation: diaphoresis, tremor, tachycardia, anxiety, hunger" +
"Neuroglycopenia: weakness, fatigue, altered mental status, coma" +


"Differential diagnosis" +

"Exogenous insulin" +
"Critical illness/sepsis" +
"Endocrine: Addison's disease, adrenal crisis, hypopituitarism" +
"Insulin producing tumors" +
"Fasting hypoglygemia: inherited liver/fatty acid oxidation enzyme deficiencies, drugs (ethanol, haloperidol)" +
"Reactive (postprandial) hypoglycemia: idiopathic or enzyme deficiencies" +


"Management" +

"Confirm glucose level" +
"Treat: IV dextrose (D5W 50ml IV); glucagon 1-2mg IM if no IV access" +
"Seizure precautions" +
"Continue to monitor & treat until glucose levels stable",

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
