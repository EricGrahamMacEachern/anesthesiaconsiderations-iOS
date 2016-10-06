using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Hypotension : ContentPage
    {
        public Hypotension()
        {
            Label header = new Label
            {
                Text = "Hypotension",
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

" preload:" +
"Bleeding" +
"Relative" +
" afterload/distributive shock:" +
"Anaphylaxis" +
"Sepsis/SIRS" +
"Neurogenic" +
"Blood transfusion reaction" +
"Neuraxial" +
"Drugs: anethetic overdose/drug swap" +
"Endocrine: Addison's, myxedema, carcinoid" +
"Metabolic: hypocalcemia, hypoglycemia" +
"Obstructive shock:" +
"Tension pneumothorax" +
"Tamponade" +
"Embolic events" +
"Pulmonary hypertension" +
"Cardiogenic shock:" +
"Rate:" +
"Bradycardia" +
"Tachycardia" +
"Arrhythmias" +
"Contractility:" +
"Ischemia" +
"Drugs or toxins" +
"RV failure/pulmonary hypertension" +
"Acute valvular pathology" +


"Management" +

"Emergency situation requiring simultaneous diagnosis & management" +
"Inform the surgeon" +
"Call for help" +
"? anesthetic & hand ventilate with 100% O2" +
"Vasopressor bolus +/- IV fluid bolus:" +
"Phenylephrine 100 mcg IV PRN" +
"Ephedrine 5-10 mg IV PRN" +
"Epinephrine 1-10 mcg IV PRN" +
"Cycle BP & scan monitors for HR, rhythm, ST changes, SaO2, EtCO2, PAP" +
"Feel for a pulse:" +
"If no pulse ? ACLS as per protocol" +
"Ensure crash cart in room:" +
"If pulse present ? targeted physical exam" +
"Urticaria, flushing, angioedema" +
"Tracheal deviation, jugular venous distention, subcutaneous crepitus, bilateral air entry" +
"JVP (jugular venous pressure) / CVP (central venous pressure) / PCWP (pulmonary capillary wedge pressure)" +
"CVP / PCWP = obstructive or cardiogenic" +
"CVP / PCWP = hypovolemic or distributive" +
"Peripheral perfusion (? in distributive, ? in others)" +
"Look at surgical field (blood loss, IVC compression, pneumoperitoneum pressure)" +
"Check IV fluids, vasopressors, blood products" +
"Reassess differential diagnosis based on findings",

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
