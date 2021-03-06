using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExamples.Views
{
    public partial class ListViewCustomWithImage : ContentPage
    {
        public ListViewCustomWithImage()
        {
            InitializeComponent();

            BindingContext = new ListViewCustomViewWithImageModel(DisplayAlert);
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public class ListViewCustomViewWithImageModel : BindableObject
        {

            readonly Func<string, string, string, Task> displayAlertAction;

            List<ListItem> _items;
            public List<ListItem> Items
            {
                get
                {
                    return _items;
                }
                set
                {
                    _items = value;
                    OnPropertyChanged("Items");
                }
            }

            public ListViewCustomViewWithImageModel(Func<string, string, string, Task> displayAlertAction)
            {
                this.displayAlertAction = displayAlertAction;

                Items = new List<ListItem> { 
                    new ListItem {Source = "first.png", Title = "First", Description="1st item", Price="$100.00"}, 
                    new ListItem {Source = "second.png", Title = "Second", Description="2nd item", Price="$200.00"},
                    new ListItem {Source = "third.png", Title = "Third", Description="3rd item", Price="$300.00"}
                };
            }
        }
    }


   
}

