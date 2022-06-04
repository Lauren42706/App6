using App6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirtItemPage : ContentPage
    {
        private Clothes _tShirt;

        public Clothes NewTShirt
        {
            get { return _tShirt; }
            set { _tShirt = value; }
        }

        public TShirtItemPage(Clothes newTshirt)
        {
            _tShirt = newTshirt;

            InitializeComponent();

            BindingContext = this;
        }
    }
}