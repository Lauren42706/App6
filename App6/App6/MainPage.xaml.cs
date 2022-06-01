using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TShirt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TShirt());
        }

        private async void Hoodie_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hoodie());
        }

        private async void Cap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CapPage());
        }

        private async void Pin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pins());
        }
    }
}
