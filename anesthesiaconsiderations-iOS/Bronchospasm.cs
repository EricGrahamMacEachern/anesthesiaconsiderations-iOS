using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Bronchospasm : ContentPage
    {
        public Bronchospasm()
        {
            Label header = new Label
            {
                Text = "Bronchospasm",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {

                    Text = "Signs\n\n" +
                          "\u2022 Wheezing on lung auscultation\n" +
                          "\u2022 Slow or incomplete expiration\n" +
                          "\u2022 Change in EtCO2\n" +
                          "\u2022 Upsloping waveform\n" +
                          "\u2022 Severe or absent waveform\n" +
                          "\u2022 tidal volume\n" +
                          "\u2022 oxygen saturation\n" +
                          "\u2022 peak airway pressure\n" +



                          "Differential Diagnosis\n\n" +

                          "\u2022 resistance:\n" +
                          "\t \u2022 Bronchial asthma\n" +
                          "\t \u2022 COPD with reversible component\n" +
                          "\t \u2022 Laryngospasm (if supraglottic airway)\n" +
                          "\t \u2022 Anaphylaxis\n" +
                          "\u2022 compliance:\n" +
                          "\t \u2022 Aspiration\n" +
                          "\t \u2022 Pulmonary edema\n" +
                          "\t \u2022 Pulmomary embolism/fat embolism/amniotic fluid embolism\n" +
                          "\t \u2022 Pneumothorax\n" +
                          "\t \u2022 Opioid-induced chest wall rigidity\n" +
                          "\t \u2022 Inadequate muscle relaxation\n" +
                          "\t \u2022 Circuit/machine problems\n" +
                          "\u2022 ETT/supraglottic airway:\n" +
                          "\t \u2022 Kinked\n" +
                          "\t \u2022 Malposition\n" +
                          "\t \u2022 Endobronchial/esophageal/submucosal\n" +
                          "\t \u2022 Herniated cuff\n" +
                          "\t \u2022 Foreign body/secretions\n" +


                          "Management\n\n" +

                          "\u2022 Adjust FiO2 as necessary, remove irritants, deepen anesthesia\n" +
                          "\u2022 Disconnect & hand-ventilate to assess compliance, rule out other possibilities\n" +
                          "\u2022 Beta 2 agonists are first line treatment:\n" +
                          "\u2022 Salbutamol 4-8 puffs via ETT OR 2.5-5mg via nebulizer q20min PRN\n" +
                          "\u2022 Epinephrine infusion 0.5-2mcg/min in severe, refractory cases\n" +
                          "\u2022 Anticholinergics: ipratropium 4-8 puffs via ETT OR 0.5 mg via nebulizer q20min PRN\n" +
                          "\u2022 Steroids: methylprednisolone 125mg IV OR dexamethasone 8mg IV\n" +
                          "\u2022 Appropriate ventilation to avoid dynamic hyperinflation:\n" +
                          "\u2022 Longer expiratory time (I:E 1:3-1:5)\n" +
                          "\u2022 Low/normal respiratory rates (8-12/min)\n" +
                          "\u2022 Permissive hypercapnia\n" +
                          "\u2022 Adjuncts:\n" +
                          "\t \u2022 Bronchodilating anesthetics: volatiles > ketamine > propofol\n" +
                          "\t \u2022 Magnesium sulfate 2g IV over 20min\n" +
                          "\t \u2022 Heliox (does not reverse bronchospasm, but can be used as a temporizing measure)\n" +
                          "\t \u2022 Neuromuscular blocking drugs (may improve mechanics of ventilation & lower peak inspiratory pressures)\n" +
                          "\t \u2022 Extracorporeal membrane oxygenation (ECMO) if severe & refractory to all other treatments\n",



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
