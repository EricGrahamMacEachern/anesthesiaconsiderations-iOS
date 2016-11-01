// Does not compile yet. 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace FormsGallery
{

    public class pageList
    {
        public pageList(string pageTitle, Type fileName)
        {
            this.pageTitle = pageTitle;
            this.fileName = fileName;
        }

        public string pageTitle { private set; get; }

        public Type fileName { private set; get; }

    };

    class DetailPage : ContentPage
    {                
        public DetailPage(pageList page_list)
        {
            this.page_list = page_list;
        }       

        public pageList page_list { private set; get; }

    }

    class Search : ContentPage
    {
        Label resultsLabel;
        SearchBar searchBar;

        ObservableCollection<pageList> pageListings = new ObservableCollection<pageList>
{
new pageList("Abdominal Aortic Aneurysm Repair (Open)", typeof(AbdominalAorticAneurysmRepairOpen)),
new pageList("Abdominal Compartment Syndrome", typeof(AbdominalCompartmentSyndrome)),
new pageList("Acetaminophen Overdose", typeof(AcetaminophenOverdose)),
new pageList("Achondroplasia", typeof(Achondroplasia)),
new pageList("Acromegaly", typeof(Acromegaly)),
new pageList("Acute Leukemia", typeof(AcuteLeukemia)),
new pageList("Acute Renal Failure", typeof(AcuteRenalFailure)),
new pageList("Acute Spinal Cord Injury", typeof(AcuteSpinalCordInjury)),
new pageList("Adrenocortical Insufficiency", typeof(AdrenocorticalInsufficiency)),
new pageList("Adult Congenital Heart Disease", typeof(AdultCongenitalHeartDisease)),
new pageList("Airway", typeof(Airway)),
new pageList("Airway Abscess and Infection", typeof(AirwayAbscessAndInfection)),
new pageList("Airway Fire", typeof(AirwayFire)),
new pageList("Airway Foreign Body", typeof(AirwayForeignBody)),
new pageList("Alcoholism", typeof(Alcoholism)),
new pageList("Amniotic Fluid Embolism", typeof(AmnioticFluidEmbolism)),
new pageList("Amyloidosis", typeof(Amyloidosis)),
new pageList("Amyotrophic Lateral Sclerosis ALS", typeof(AmyotrophicLateralSclerosisALS)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
};
        ObservableCollection<pageList> _viewModels = new ObservableCollection<pageList>
{
new pageList("Abdominal Aortic Aneurysm Repair (Open)", typeof(AbdominalAorticAneurysmRepairOpen)),
new pageList("Abdominal Compartment Syndrome", typeof(AbdominalCompartmentSyndrome)),
new pageList("Acetaminophen Overdose", typeof(AcetaminophenOverdose)),
new pageList("Achondroplasia", typeof(Achondroplasia)),
new pageList("Acromegaly", typeof(Acromegaly)),
new pageList("Acute Leukemia", typeof(AcuteLeukemia)),
new pageList("Acute Renal Failure", typeof(AcuteRenalFailure)),
new pageList("Acute Spinal Cord Injury", typeof(AcuteSpinalCordInjury)),
new pageList("Adrenocortical Insufficiency", typeof(AdrenocorticalInsufficiency)),
new pageList("Adult Congenital Heart Disease", typeof(AdultCongenitalHeartDisease)),
new pageList("Airway", typeof(Airway)),
new pageList("Airway Abscess and Infection", typeof(AirwayAbscessAndInfection)),
new pageList("AirwayFire", typeof(AirwayFire)),
new pageList("Airway Foreign Body", typeof(AirwayForeignBody)),
new pageList("Alcoholism", typeof(Alcoholism)),
new pageList("Amniotic Fluid Embolism", typeof(AmnioticFluidEmbolism)),
new pageList("Amyloidosis", typeof(Amyloidosis)),
new pageList("Amyotrophic Lateral Sclerosis ALS", typeof(AmyotrophicLateralSclerosisALS)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
};

        public Search()
        {
            BackgroundColor = Color.White;

            Label header = new Label
            {
                Text = "Search",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            // Define the page listings. 
            resultsLabel = new Label
            {
                Text = "Result will appear here.",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25
            };

            searchBar = new SearchBar
            {
                Placeholder = "Enter search term",
                TextColor = Color.Black,
            };
    
        StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {

                    searchBar,
                    new ScrollView
                    {
                        Content = resultsLabel,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                },
            };



        // Create the ListView.
        ListView listView = new ListView
            {



                // Source of data items.
                ItemsSource = pageListings,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property
                    Label pageLabel = new Label();

                    pageLabel.SetBinding(Label.TextProperty, "pageTitle");

                    pageLabel.TextColor = Color.Black;



            return new ViewCell
                    {

                        View = new StackLayout
                        {

                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,

                                    Spacing = 0,
                                    Children =
                                    {
                                        pageLabel,
                                    }
                                }
                            }
                        }
                    };
                })



            };


            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    stackLayout,
                    listView
                }
            };

            searchBar.TextChanged += (sender, e) => Filter(listView, e.NewTextValue);
            searchBar.SearchButtonPressed += (sender, args) => Filter(listView, searchBar.Text);
            
            listView.ItemTapped += async (sender, args) =>
             {

                 var itemSelected = args.Item as pageList;
                 if (itemSelected != null)
                 {
                         var page = (ContentPage)System.Activator.CreateInstance(itemSelected.fileName);
                         await Navigation.PushAsync(page, true);
                     
                 }
                                  
             };
             
             


        }

        private void Filter(ListView listView, string newTextValue)
        {
            listView.ItemsSource = string.IsNullOrEmpty(newTextValue)
            ? (IEnumerable<pageList>)pageListings
            : _viewModels.Where(itemSearch => itemSearch.pageTitle.ToLower().Contains(newTextValue.ToLower()))
            .ToList();
        }

    }


}

