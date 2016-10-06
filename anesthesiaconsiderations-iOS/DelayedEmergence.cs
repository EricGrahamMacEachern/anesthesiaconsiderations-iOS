using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DelayedEmergence : ContentPage
    {
        public DelayedEmergence()
        {
            Label header = new Label
            {
                Text = "Delayed Emergence",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Differential Diagnosis ('DIMS')\n\n" +

"Drugs\n" +
"\u2022 Anesthesia related:\n" +
"\u2022 Sedatives & narcotics\n" +
"\u2022 Residual paralysis, pseudocholinesterase deficiency\n" +
"\u2022 Drug error\n" +
"\u2022 Non-anesthesia related:\n" +
"\u2022 Street drugs, alcohol\n" +
"\u2022 Herbal medicines (valerian root, St. John's wort)\n\n" +
"Infection:\n\n" +
"\u2022 Encephalitis, meningitis\n" +
"\u2022 Sepsis\n\n" +
"\u2022 Metabolic:\n\n" +
"\u2022 Hypoxia\n" +
"\u2022 Hypercarbia\n" +
"\u2022 Electrolyte abnormalities\n" +
"\u2022 Hypoglycemia or hyperglycemia (DKA or HONK)\n" +
"\u2022 Hypothermia\n" +
"\u2022 Uremia\n" +
"\u2022 Hepatic encephalopathy\n" +
"\u2022 Osmolality problems\n\n" +
"Myxedema coma\n\n" +
"\u2022 Structural:\n\n" +
"\u2022 Stroke (ischemic or hemorrhagic)\n" +
"\u2022 Hydrocephalus\n" +
"\u2022 Diffuse anoxic injury\n" +
"\u2022 Cerebral edema\n" +
"\u2022 Seizure or post-ictal\n" +
"\u2022 Pneumocephalus\n" +
"\u2022 Cerebral hyperperfusion syndrome (post carotid endarterectomy)\n\n" +


"Management\n\n" +

"Scan monitors: HR, ECG, rhythm, EtCO2, SpO2, BP, temp\n" +
"\u2022 \t Ensure stability of ABC's\n" +
"\u2022 \t Confirm reversal of paralysis\n" +
"\u2022 \t Review all drugs administered & syringes for drug error\n" +
"\u2022 Focused physical exam:\n" +
"\u2022 \t Neurological: GCS, pupils, gag/cough, symmetric motor movement, focal signs\n" +
"\u2022 \t Cardiorespiratory: adequacy of perfusion\n\n" +
"\u2022 Blood work:\n" +
"\u2022 \t CBC, lytes, urea, creatinine, glucometer, osmolality, ABG with lactate & ionized calcium\n" +
"\u2022 \t Liver enzymes, bilirubin\n" +
"\u2022 \t Toxicology screen\n" +
"\u2022 \t TSH, FT4\n" +
"\u2022 Consider: Neurology / ICU consultation, CT head, EEG, lumbar puncture\n\n" +
"\u2022 \t Empiric therapy:\n" +
"\u2022 \t Glucose: 25-50 cc of D50 or 250 cc of D10\n" +
"\u2022 \t Thiamine 100 mg IV\n" +
"\u2022 \t Opioid reversal: naloxone 0.04 mg IV q 2 mins, up to 2mg\n" +
"\u2022 \t Benzodiazepine reversal: flumazenil 0.2-1 mg IV q 1 min, up to 1mg\n" +
"\u2022 \t Physostigmine (0.5 to 1 mg IV) counteracts but does not reverse sedation caused by inhalation anesthetics, other sedatives, & anticholinergics\n",

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
