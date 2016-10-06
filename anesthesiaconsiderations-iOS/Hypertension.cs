using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hypertension : ContentPage
    {
        public Hypertension()
        {
            Label header = new Label
            {
                Text = "Hypertension",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hypertension" +


"Differential Diagnosis" +

"Hypoxemia, hypercarbia" +
"Drugs:" +
"Vasopressors, cocaine, MAOIs, stimulants" +
"Drug errors" +
"Acute withdrawal: EtOH, benzodiazepines, opioids, clonidine, beta-blockers" +
"Pain, inadequate anesthesia:" +
"Laryngoscopy/intubation" +
"Surgical stimulation, laparoscopy" +
"Remote (distended bladder)" +
"Awareness" +
"Patient factors:" +
"Pre-existing hypertension" +
"Pre-eclampsia" +
"High ICP (Cushing reflex)" +
"Autonomic dysreflexia" +
"Endocrine:" +
"Hyperthyroidism" +
"Pheochromocytoma" +
"Carcinoid" +
"Malignant hyperthermia" +
"Serotonin syndrome" +
"Hyperaldosteronism" +
"Cushing syndrome" +
"Equipment error (falsely high reading)" +


"Management" +

"Inform surgeon, request cessation of surgical stimulation" +
"Cycle BP, scan monitors for HR, ECG rhythm, EtCO2, temperature" +
"Provided the patient is adequately oxygenated & ventilated, deepen anesthetic" +
"Examine patient:" +
"Pupils (high ICP)" +
"Diaphoresis & flushing (carcinoid, pheochromocytoma, hyperthyroidism)" +
"Rigidity (malignant hyperthermia, serotonin syndrome)" +
"Bladder distension" +
"Hot (thyroid storm, malignant hyperthermia, serotonin syndrome)" +
"Examine drugs & equipment:" +
"Potential drug error" +
"Possible TIVA or circuit disconnect (awareness)" +
"Tourniquet (pain)" +
"Equipment error (falsely high reading)" +
"Temporize​:" +
"Labetalol 5-20mg IV q10 min (max total 300mg)" +
"Esmolol 0.5mg/kg IV over 1 minute; start infusion at 50mcg/kg/min" +
"Hydralazine 5-20mg IV (max 30mg) slow IV push every 20 minutes" +
"Nitroglycerin 50-100mcg IV; start infusion at 10mcg/min" +
"Treat underlying cause" +


"Complications" +

"CVS: MI, arrhythmia, CHF/pulmonary edema, dissection" +
"CNS: intracranial hemorrhage" +
"↑ surgical bleeding",

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
