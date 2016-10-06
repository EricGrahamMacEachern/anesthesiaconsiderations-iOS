using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AirwayFire : ContentPage
    {
        public AirwayFire()
        {
            Label header = new Label
            {
                Text = "Airway Fire",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Management\n\n" +

"\u2022 Inform team & call for help \n" +
"\u2022 Simultaneously remove the endotracheal tube (ETT) & stop gases/disconnect circuit\n" +
"\u2022 Pour saline or water into airway\n" +
"\u2022 Remove airway foreign bodies (ie: ETT pieces, sponges)\n" +
"\u2022 When fire is extinguished: re-establish ventilation; avoid supplemental oxygen if possible\n" +
"\u2022 Consider prompt reintubation prior to swelling & coordinated with bronchoscopy\n" +
"\u2022 Examine entire airway (including bronchoscopy) to assess injury & remove residual debris\n\n" +


"Prevention\n\n" +

"\u2022 For high risk procedures:\n" +
"\t \u2022 Discuss fire prevention & management with team during time-out\n" +
"\t \u2022 Avoid FiO2 > 0.3 & avoid N2O\n\n" +

"\u2022 For laser surgery of vocal cord or larynx:\n" +
"\t \u2022 Use laser resistant ETT (single or double cuff)\n" +
"\t \u2022 Assure ETT cuff sufficiently deep below vocal cords\n" +
"\t \u2022 Fill proximal ETT cuff with methylene blue-tinted saline (acts as a marker if cuff perforated by laser)\n" +
"\t \u2022 Ensure laser in STANDBY when not in active use\n" +
"\t \u2022 Surgeon protects ETT cuff with wet gauze\n" +
"\t \u2022 Surgeon confirms FiO2 < 0.3 & no N2O prior to laser use (may require several minutes to dilute FiO2 & FeO2 to <0.3 depending on fresh gas flow & initial FiO2)\n\n" +

"\u2022 For non-laser surgery in oropharynx:\n" +
"\t \u2022Regular PVC ETT may be used\n" +
"\t \u2022Consider packing wet gauze around ETT to minimize O2 leakage\n" +
"\t \u2022Consider continuous suctioning of the operating field inside oropharynx\n",

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
