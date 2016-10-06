using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TotalSpinal : ContentPage
    {
        public TotalSpinal()
        {
            Label header = new Label
            {
                Text = "Total Spinal",
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

"Numbness or weakness in upper extremities" +
"Nausea/vomiting" +
"Dyspnea/respiratory depression" +
"Loss of consciousness" +
"Bradycardia" +
"Hypotension" +
"Dilated pupils" +


"Management" +

"Supportive care:" +
"Assess need for intubation and/or cardiopulmonary resuscitation" +
"Maintain oxyvenation/ventilation & protect against aspiration" +
"Support hemodynamics:" +
"IV fluid bolus, atropine, epinephrine (10 - 100ug IV, increase as needed)" +
"If pregnant: left uterine displacement & fetal heart rate monitoring" +
"Consider sedation when hemodynamically stable" +
"Change position based on baricity (careful with reverse trendelenberg & hypotension → venous pooling)" +
"Support until spinal wears off",

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
