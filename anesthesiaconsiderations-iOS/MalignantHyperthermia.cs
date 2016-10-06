using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class MalignantHyperthermia: ContentPage
    {
        public MalignantHyperthermia()
        {
            Label header = new Label
            {
                Text = " Malignant Hyperthermia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Malignant Hyperthermia (MH)\n\n" +



"Signs (early)\n" +

"↑ EtCO2" +
"Tachycardia" +
"Tachypnea" +
"Mixed acidosis" +
"Masseter spasm/trismus" +
"Sudden cardiac arrest due to hyperkalemia" +

"Signs (may be later)\n" +

"Hyperthermia" +
"Muscle rigidity" +
"Myoglobinuria" +
"Arrhythmias" +
"Cardiac arrest" +


"Differential Diagnosis\n" +

"Neuroleptic malignant syndrome: similar presentation to MH but associated with use of antipsychotic neuroleptic medications (also treated with dantrolene)" +
"Thyroid storm: fever, tachycardia, altered mental status" +
"Anaphylaxis: cardiovascular collapse without hypermetabolic features" +
"Pheochromocytoma: significant hypertension" +
"Drug toxicity: consider clinical context, screen urine/plasma" +


"Management\n" +

"Alert surgeon & call for help" +
"Stop anesthetic triggers (volatiles & succinylcholine), ↑ fresh gas flow to 10L/min; do not change machine or circuit" +
"If available, insert activated charcoal filters into the inspiratory & expiratory limbs of the breathing circuit" +
"↑ to 100% FiO2 & ↑ minute ventilation" +
"Halt surgery; if emergent, continue with non-triggering anesthetic" +
"Call MH hotline:" +
"MHAUS (Malignant Hyperthermia Association of the United States)" +
"1 800 644 9737 (within USA); 00 1 209 417 3722 (outside USA)" +
"Assign several people to prepare dantrolene 2.5 mg/kg IV bolus:" +
"Dilute each 20 mg dantrolene vial in 60 mL preservative-free sterile water" +
"For 70 kg person, give 175 mg (prepare 9 vials of 20 mg dantrolene)" +
"Rapidly administer dantrolene & continue giving until patient stable" +
"May need > 10 mg/kg" +
"Cool patient: IV fluids, ice packs, gastric / peritoneal lavage" +
"Treat arrhythmias:" +
"Usually secondary to hyperkalemia" +
"Treat in standard fashion, however avoid calcium channel blockers" +
"Treat metabolic acidosis:" +
"Sodium bicarbonate 1 to 2mEq/kg PRN for base excess greater than -8 (max dose 50mEq)" +
"Treat hyperkalemia:" +
"Hyperventilation" +
"Calcium chloride 10mg/kg (max dose 2g) or calcium gluconate 30mg/kg (max 3g)" +
"D50 1 amp IV (25g dextrose) + regular insulin 10 units IV → monitor glucose" +
"Sodium bicarbonate 1 amp" +
"Furosemide 0.5-1mg/kg once" +
"For refractory hyperkalemia, consider beta-agonist, kayexalate, dialysis, or ECMO if in cardiac arrest" +
"Monitor temperature, electrolytes, arterial/venous blood gases, creatine kinase, urine output, coagulation studies, lactic acid" +
"Place foley catheter, monitor urine output" +
"When stable, transfer to post anesthesia care unit or intensive care unit for at least 24 hours" +
"Monitor for recurrence & continue dantrolene 1 mg/kg q 4-6 hours x 24 to 48 hours" +
"Refer for genetic counseling/in-vitro muscle contracture testing",

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
