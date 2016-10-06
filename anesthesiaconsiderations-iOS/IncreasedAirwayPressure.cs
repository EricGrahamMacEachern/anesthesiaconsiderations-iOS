using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class IncreasedAirwayPressure : ContentPage
    {
        public IncreasedAirwayPressure()
        {
            Label header = new Label
            {
                Text = "Increased Airway Pressure",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Differential diagnosis" +

"Circuit or machine problem:" +
"Ventilator/bag switch in wrong position" +
"Stuck valve (inspiratory/expiratory/APL)" +
"Oxygen flush valve stuck in 'on' position" +
"Kinked/misconnected hose in circuit/scavenge limb" +
"Failure of check valves/regulators in machine, allowing high-pressure gas into low-pressure circuit" +
"PEEP valve accidentally placed in inspiratory limb" +
"ETT/supraglottic airway problem:" +
"Kinked tube" +
"Malpositioned supraglottic airway" +
"Endobronchial, esophageal, submucosal intubation" +
"Herniated cuff obstructing end of tube" +
"Dissection of interior surface of tube leading to airway narrowing" +
" pulmonary compliance:" +
" intra-abdominal pressure" +
"Pulmonary aspiration" +
"Bronchospasm " +
" chest wall compliance" +
"Pulmonary edema" +
"Pneumothorax" +
"Drug-induced problem:" +
"Opioid-induced chest wall rigidity" +
"Inadequate muscle relaxation" +
"Malignant hyperthermia" +
"Laryngospasm (if using supraglottic airway)" +


"Management" +

" FiO2 to 100%" +
"Verify the peak inspiratory pressure" +
"Switch to manually using reservoir bag; assess pulmonary & circuit compliance" +
"Disconnect circuit from ETT & squeeze bag:" +
"If PIP still high, obstruction in circuit; ventilate using BVM connected to 100% FiO2" +
"Get help to replace/repair circuit" +
"Auscultate chest & neck:" +
"Listen for symmetry (endobronchial, tension, or simple pneumothorax) & for adventitious sounds (pulmonary edema, bronchospasm)" +
"Listen for stridorous sound of laryngospasm" +
"Examine trachea for deviation, check HR & BP" +
"Exclude ETT obstruction:" +
"Pass suction catheter down ETT & apply suction to clear secretions" +
"If ETT obstructed, deflate cuff & repeat" +
"Consider fiberoptic bronchoscopy to elucidate problem" +
"Remove & reintubate if necessary" +
"Check for other causes of ↓ chest compliance:" +
"Malignant hyperthermia" +
"Aspiration" +
"Inadequate muscle relaxation" +
"Opiates" +
"Excessive surgical retraction" +
"Abnormal anatomy (ie: scoliosis)",

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
