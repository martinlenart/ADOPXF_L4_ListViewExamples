using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ListViewExamples.Models;
namespace ListViewExamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroupedLinq : ContentPage
    {
        public ListViewGroupedLinq()
        {
            InitializeComponent();

            var items = new RectangleModel().Rectangles;
            var groupedList = items.OrderByDescending(r => r.Area).GroupBy(r => r.Color, r => r);

            CustomGroupedList.ItemsSource = groupedList;
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListViewExamples.Models.Rectangle;
            if (item != null) await DisplayAlert("Item tapped", $"Rectangle selected: {item}", "OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}