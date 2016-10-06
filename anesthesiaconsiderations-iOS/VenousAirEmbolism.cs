using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class VenousAirEmbolism : ContentPage
    {
        public VenousAirEmbolism()
        {
            Label header = new Label
            {
                Text = "Venous Air Embolism",
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

"Air on TEE or change in doppler tone if monitoring" +
" ETCO2" +
" BP" +
" SpO2" +
" CVP" +
"Bronchospasm" +
"Dyspnea & respiratory distress or cough in awake patient " +
"Mill wheel murmur on cardiac auscultation (late sign)" +


"Management" +

"Goals: prevent further entrainment of air, hemodynamic support, treat existing air " +
"Inform surgeon" +
"Flood surgical field with saline & apply bone wax " +
"Supportive therapy:" +
"100% oxygen, decrease or turn off volatile anesthetic" +
"Stop nitrous oxide" +
"IV fluid bolus" +
"Vasopressors (epinephrine, norepinephrine, dobutamine)" +
"Positioning:" +
"Place surgical site below heart (if able)" +
"Lower the head position & compress the jugular veins " +
"Reposition the patient into left lateral decubitus, trendelenberg, or left lateral decubitus head down position (controversial - poor evidence & often impractical to do in the OR)" +
"Definitive therapy:" +
"Hyperbaric oxygen therapy (especially if paradoxical air embolism) " +
"Aspirate air from the central catheter if in situ" +
"Closed chest cardiac massage (chest compressions)" +
"PEEP is of no value & increases risk of paradoxical air embolism" +
"Consider TEE to assess air & RV function",




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
