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
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
};
        ObservableCollection<pageList> _viewModels = new ObservableCollection<pageList>
{
new pageList("Abdominal Aortic Aneurysm Repair (Open)", typeof(AbdominalAorticAneurysmRepairOpen)),
new pageList("Abdominal Compartment Syndrome", typeof(AbdominalCompartmentSyndrome)),
new pageList("Acetaminophen Overdose", typeof(AcetaminophenOverdose)),
new pageList("Achondroplasia", typeof(Achondroplasia)),
new pageList("Acromegaly", typeof(Acromegaly)),
new pageList("Anaphylaxis", typeof(Anaphylaxis)),
};

        public Search()
        {


            Label header = new Label
            {
                Text = "ListView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Define the page listings. 
            resultsLabel = new Label
            {
                Text = "Result will appear here.",
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25
            };

            searchBar = new SearchBar
            {
                Placeholder = "Enter search term",
            };
    
        StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "SearchBar",
                        FontSize = 50
                    },
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

