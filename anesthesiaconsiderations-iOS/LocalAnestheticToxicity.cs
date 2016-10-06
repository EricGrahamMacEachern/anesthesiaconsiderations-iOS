using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class LocalAnestheticToxicity : ContentPage
    {
        public LocalAnestheticToxicity()
        {
            Label header = new Label
            {
                Text = "Local Anesthetic Toxicity",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Signs & Symptoms" +

"Tinnitus, metalic taste, circumoral numbess" +
"Altered mental status" +
"Seizures" +
"Hypotension" +
"Bradycardia" +
"Ventricular arrhythmias" +
"Cardiovascular collapse" +


"Management" +

"Stop local anesthetic injection &/or infusion" +
"Call for help" +
"Initial focus:" +
"Airway management: ensure adequate ventilation & oxygenation; 100% FiO2, consider ETT, prevent hypoxia & acidosis (aggravate LAST)" +
"Seizure suppression: benzodiazepines preferred, avoid/minimize propofol if hemodynamically unstable; if seizures persist, small doses of succinylcholine to minimize acidosis & hypoxia" +
"Alert nearest facility having cardiopulmonary bypass capability" +
"Management of cardiac arrhythmias:" +
"If pulseless, start CPR" +
"ACLS will require adjustment of medications & perhaps prolonged effort" +
"Epinephrine doses <1 mcg/kg (small boluses of 10-100 mcg IV)" +
"Avoid vasopressin, calcium channel blockers, beta blockers, & local anesthetics" +
"If ventricular arrhythmias occur, amiodarone is preferred; avoid lidocaine & procainamide" +
"If refractory to treatment, consider cardiopulmonary bypass" +
"Lipid emulsion (20%) therapy:" +
"Rapidly administer at the first signs of LAST 1.5ml/kg bolus (70kg = 105ml) over 1 minute, then start infusion at 0.25mL/kg/min" +
"Repeat bolus once or twice for persistent cardiovascular collapse" +
"May ↑ infusion rate (max 0.5mL/kg/min) if BP remains low" +
"Continue infusion for at least 10 minutes after attaining circulatory stability" +
"Recommended upper limit 10mL/kg over the first 30 minutes" +
"Propofol is not a substitute for lipid emulsion" +
"Failure to respond to lipid emulsion & vasopressor therapy should prompt institution of cardiopulmonary bypass (ECMO)",

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
