using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hypoxemia : ContentPage
    {
        public Hypoxemia()
        {
            Label header = new Label
            {
                Text = "Hypoxemia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Differential Diagnosis" +

"Low FiO2:" +
"Oxygen failure or pipeline crossover of gases" +
"Hypoventilation:" +
"Low TV or RR" +
"Ventilator dyssynchrony" +
"Circuit leak" +
"Obstructed ETT" +
"V/Q mismatch or shunt:" +
"Airway:" +
"Bronchospasm" +
"Mainstem intubation" +
"Mucous plug" +
"Alveolar:" +
"Pulmonary edema" +
"Aspiration" +
"Atelectasis" +
"Pleura:" +
"Pneumothorax" +
"Pleural effusion" +
"Deadspace:" +
"Pulmonary embolism" +
"Low cardiac output state" +
" metabolic O2 demand:" +
"Malignant hyperthermia, thyrotoxicosis, sepsis, hyperthermia, neuroleptic malignant syndrome" +
"Diffusion abnormality:" +
"Chronic lung disease" +
"Artifacts:" +
"Confirm by ABG" +
"Poor waveform (probe malposition, cold extremity, light interference, cautery)" +
"Dyes (methylene blue, indigo carmine, blue nail polish)" +


"Management" +

" FiO2 to 100%, high flow" +
"Check gas analyzer to rule out low FiO2 or high N2O" +
"Check other vitals, cycle NIBP, check peak inspiratory pressure, feel for pulse" +
"Check ETCO2 (?extubated/disconnected/low BP)" +
"Hand ventilate (check compliance, rule out leaks & machine factors)" +
"Listen for breath sounds" +
"Check position of ETT" +
"Soft suction via ETT (to clear secretions & check for obstructions)" +
"Consider code cart if severe" +
"Depending on likely diagnosis, consider:" +
"Large recruitment breaths, consider PEEP" +
"Bronchodilators" +
"Additional neuromuscular blockade" +
" FRC (head up, desufflate abdomen)" +
"Fiberoptic to rule out mainstem intubation or ETT obstruction" +
"ABG, CXR" +
"Consider terminating surgery for refractory hypoxemia" +
"Plan for post-op care ",

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
