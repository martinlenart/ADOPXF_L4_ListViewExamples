using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace ListViewExamples.Views
{
    public partial class ListViewStrings : ContentPage
    {
        public List<string> Items { get; }
        public ListViewStrings()
        {
            InitializeComponent();
            Items = new List<string>
            {
                "First",
                "Second",
                "Third"
            };
            BindingContext = this;
        }
 
        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            string item = (string)e.Item;
            await DisplayAlert("Tapped", item + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string item = (string)e.SelectedItem;
            await DisplayAlert("Selected", item + " was selected.", "OK");
        }
    }
}

