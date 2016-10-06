using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TransfusionReactions : ContentPage
    {
        public TransfusionReactions()
        {
            Label header = new Label
            {
                Text = "Transfusion Reactions",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text =

"Transfusion-associated circulatory overload (TACO)" +

"Signs:" +
"Respiratory distress, hypoxia" +
" BP" +
"Acute or worsening pulmonary edema" +
"Positive fluid balance" +
"Management:" +
"Stop transfusion " +
"Supplemental oxygen" +
"Diuretics" +


"Transfusion-related acute lung injury (TRALI)" +

"Signs:" +
"Acute hypoxia & noncardiac pulmonary edema within 6 hours of transfusion (usually plasma)" +
" BP" +
"Management:" +
"Supplemental oxygen, endotracheal intubation / ventilation" +
"Similar treatment to acute respiratory distress syndrome (ARDS)" +
"Hemodynamic support" +


"Urticarial reaction" +

"Signs:" +
"Erythema, hives, itching" +
"No fever" +
"Management:" +
"Antihistamines, steroids" +
"Transfusion may be continued if reaction mild" +


"Complications of Massive Transfusion" +

"Dilutional coagulopathy" +
"Hypothermia" +
"Hyperkalemia" +
"Complications of citrate infusion:" +
"Hypocalcemia" +
"Metabolic acidosis or alkalosis",


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
