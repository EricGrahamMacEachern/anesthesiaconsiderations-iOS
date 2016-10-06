using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class FatEmbolism : ContentPage
    {
        public FatEmbolism()
        {
            Label header = new Label
            {
                Text = "FatEmbolism",
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

"Hypoxemia (most common early sign)" +
"Neurological abnormalities (majority of patients)" +
"Petechial rash (only 20-50% of patients; usually on conjuctiva, oral mucosa, skin folds of neck & axillae)" +


"Management" +

"Supportive treatment:" +
"Respiratory support: intubation/ventilation, treat as ARDS (lung protective strategy)" +
"Hemodynamic support: fluid resuscitation, vasopressors, invasive monitors, TEE +" +
"Steroids: no strong evidence but consider in refractory cases" +
"Reduce incidence/severity:" +
"Early immobilization of fractures" +
"Operative correction rather than traction alone" +
"Limitation of the intraosseus pressure during orthopedic procedures",

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
