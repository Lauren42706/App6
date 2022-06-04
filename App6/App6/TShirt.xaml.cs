using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App6.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirt : ContentPage
    {
        public TShirt()
        {
            InitializeComponent();   
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tShirt = e.Item as Clothes;

            // this will determine if there is no info coming from PokedexListView
            if (tShirt != null)
                await Navigation.PushAsync(new TShirtItemPage(tShirt));
        }
    }
}