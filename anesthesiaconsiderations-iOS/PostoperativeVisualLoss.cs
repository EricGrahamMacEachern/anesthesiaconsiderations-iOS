using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PostoperativeVisualLoss : ContentPage
    {
        public PostoperativeVisualLoss()
        {
            Label header = new Label
            {
                Text = "Postoperative Visual Loss ",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Signs" +

"New ST segment or T wave changes" +
"New left bundle branch block" +
"Arrhythmias, conduction abnormalities" +
"Unexplained tachycardia, bradycardia, or hypotension" +
"Development of pathological Q waves" +
"Regional wall motion abnormalities or new/worse mitral regurgitation on TEE" +


"Management" +

"Assess need for airway management & initiation of cardiopulmonary resuscitation" +
"Verify ischemia (12 lead ECG or expanded monitor view)" +
"Optimize myocardial oxygen supply:" +
"FiO2" +
"Treat anemia if present" +
"Optimize BP (maintain coronary perfusion pressure) & HR (avoid tachycardia)" +
" coronary oxygen demand:" +
"Analgesia " +
"Nitrates (careful in hypotension)" +
"Beta blockers (careful in hypotension & acute heart failure)" +
"Optimize BP (avoid increased afterload) & HR (avoid tachycardia)" +
"Discuss aborting procedure with surgical team" +
"Discuss aspirin & anticoagulation with surgical team & cardiology team" +
"Send labs: troponin, CBC, ABG" +
"Initiate invasive monitoring, consider central venous access" +
"Consider TTE/TEE for monitoring volume status & regional wall motion abnormalities" +
"If hemodynamically unstable, consider intra-aortic balloon pump" +
"Admit to HAU/ICU/CCU",





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
