using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App6.Models;
using App6.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();


            ClothesDatabase database = await ClothesDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }
    }
}