using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaxiSafeMob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Polsovatel : ContentPage
    {
        public Polsovatel()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Dtp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dtp());
        }

        private async void Otziv_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Otziv());
        }

        private async void TaxiZakaz_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zakaztaxi());
        }
    }
}