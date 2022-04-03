using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExamples.Views
{
    public partial class ListViewDataModel : ContentPage
    {
        public List<ListItem> Items { get; }
        public ListViewDataModel()
        {
            InitializeComponent();
            Items = new List<ListItem>
            {
                new ListItem {Title = "First", Description="1st item"},
                new ListItem {Title = "Second", Description="2nd item"},
                new ListItem {Title = "Third", Description="3rd item"}
            };

            BindingContext = this;
            //DataModelList.ItemsSource = Items;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

    }
}

