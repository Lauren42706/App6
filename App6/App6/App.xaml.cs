using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App6.Data;
using App6;


namespace App6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = (Color)App.Current.Resources["DarkPurple"]
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
