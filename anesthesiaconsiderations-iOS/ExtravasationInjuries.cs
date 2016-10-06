using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ExtravasationInjuries : ContentPage
    {
        public ExtravasationInjuries()
        {
            Label header = new Label
            {
                Text = "Extravasation Injuries",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Management of Vasopressor Extravasation" +

"Stop injection/infusion immediately; leave the catheter in place" +
"Place immediate substitute IV access; resume vasopressors" +
"Slowly aspirate as much of the drug as possible" +
"Elevate the area & apply warm compresses for 48 hours" +
"Consult plastic surgery & vascular surgery for opinion & ongoing management" +
"Reversal:" +
"First line: phentolamine subcutaneously" +
"Dilute phentolamine 5 mg in 10 mL 0.9% sodium chloride" +
"A dose of 0.1-0.2 mg/kg (up to a maximum of 10 mg) should then be injected through the catheter & subcutaneously around the site" +
"Use 25 g or smaller needle" +
"Additional injections may be required if blanching returns" +
"Systemic hypotension may occur" +
"Other options:" +
"Topical nitroglycerin 2% 1-inch strip applied to the site of ischemia (redose q8h PRN)" +
"Terbulatine subcutaneously 1mg in 10ml NS, inject locally across symptomatic sites" +
"Consider sympathetic block, e.g. stellate ganglion (case reports of success)" +
"Consider a saline-wash out method or liposuction:" +
"Saline wash out:" +
"Probably the most effective way of removing drug from the site of extravasation & has been shown to reduce tissue injury" +
"Under sterile conditions with local or general anaesthesia, four to six stab incisions are made around the area of extravasation" +
"A blunt-ended cannula is inserted through one of the incisions & a large volume of saline flushed through the subcutanous tissues" +
"The saline exits through the other incisions" +
"Liposuction:" +
"Blunt-ended liposuction cannula is inserted into the area of extravasation & used to aspirate fat & extravasated material" +
"Less effective than saline washout" +


"Prevention" +

"Avoid IVs in the hand/wrist" +
"Avoid unreasuring IVs" +
"Perform protocolized extremity checks" +
"Keep antidotes & worksheet in the room with the patient" +
"10 mg of phentolamine mesylate can be added to each liter of solution containing norepinephrine (the vasopressor effect of norepinephrine is not affected)",

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
