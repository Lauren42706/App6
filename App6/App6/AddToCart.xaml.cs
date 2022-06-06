using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App6;
using App6.Models;
using App6.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToCart : ContentPage
    {
        public AddToCart()
        {
            InitializeComponent();
        }

        private Clothes _adding;

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            var todoItem = (Clothes)BindingContext;
            ClothesDatabase database = await ClothesDatabase.Instance;
            await database.SaveItemAsync(todoItem);

            await Navigation.PushAsync(new CartPage
            {
                BindingContext = new Clothes()
            });
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            var todoItem = (Clothes)BindingContext;
            ClothesDatabase database = await ClothesDatabase.Instance;
            await database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        public Clothes Adding
        {
            get { return _adding; }
            set { _adding = value; }
        }

        public AddToCart(Clothes adding)
        {
            _adding = adding;

            InitializeComponent();

            BindingContext = this;
        }
    }
}