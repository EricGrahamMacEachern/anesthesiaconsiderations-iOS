using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Seizure : ContentPage
    {
        public Seizure()
        {
            Label header = new Label
            {
                Text = "Seizure",
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

"Epilepsy or other primary seizure disorder" +
"Drugs:" +
"Withdrawal syndromes (e.g. alcohol)" +
"Drug overdoses" +
"Illicit drugs (cocaine) " +
"Local anesthetic toxicity" +
"Infection:" +
"Meningitis" +
"Encephalitis  " +
"Sepsis " +
"Metabolic:" +
"Hypoglycemia" +
"Hypoxemia/hypercarbia" +
"Hyponatremia/hypocalcemia/hypomagnesemia" +
"Toxins (uremic, hepatic encephalopathy) " +
"Dialysis disequilibrium syndrome" +
"Porphyria" +
"Structural:" +
"Ischemic or hemorrhagic stroke" +
"Intracranial tumor " +
"Cerebral edema" +
"Pregnancy:" +
"Eclamptic seizure " +
"Amniotic fluid embolism " +


"Management" +

"Inform surgical team & call for help" +
"Supplemental oxygen, monitors, establish IV access " +
"If needed, hand ventilate with 100% O2 - DO NOT hyperventilate (? seizure threshold) " +
"Focused cardiorespiratory & neurological exams " +
"Rapid glucometer" +
"Bloodwork: CBC, electrolytes, extended electrolytes, blood glucose, liver enzymes, kidney function tests, ABG" +
"Give anticonvulsants if seizure > 2min: " +
"Benzodiazepines = 1st line" +
"Midazolam 0.05mg/kg or 1mg at a time, titrate to effect" +
"Diazepam 0.1-0.4mg/kg IV, 0.04-0.2 mg/kg PR" +
"Lorazepam 1-2 mg at a time, titrate to effect" +
"Propofol 0.5mg/kg at a time, titrate to effect" +
"Phenytoin 20mg/kg total loading dose at a rate of 50mg/min, watch for hypotension & arrhythmias " +
"Barbiturates:" +
"Phenobarbital 20 mg/kg infused at a rate of 50 mg/minute" +
"Thiopental 25-100mg dose" +
"Pentobarbital 10 mg/kg infused at a rate of up to 100 mg/minute " +
"Valproic acid IV 30mg/kg over 15 min " +
"Consult neurology for further diagnosis & management " +
"If ? ICP: institute treatment (mannitol, furosemide, hypertonic saline, mild hyperventilation, elevate HOB, etc) " +
"If eclampsia: MgSO4 4g IV bolus over 15 min, then 1-2g/hr " +
"If no resolution & respiratory compromise:" +
"Paralyze & intubate " +
"Succinylcholine IM (4mg/kg) for intubation if no IV access ",

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
