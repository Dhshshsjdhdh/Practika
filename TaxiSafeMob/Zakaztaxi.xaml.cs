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
    public partial class Zakaztaxi : ContentPage
    {
        public Zakaztaxi()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Polsovatel());
        }

        private async void Otpravka_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Adres.Text))
            {
                await DisplayAlert("Ошибка", "Вы должны указать адрес старта маршрута", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Punkt.Text))
            {
                await DisplayAlert("Ошибка", "Вы должны указать конечный адрес маршрута", "OK");
                return;
            }
            await DisplayAlert("Успех!", "Ваше сообщение зафиксировано! Ожидайте новое такси", "OK");
            await Navigation.PushAsync(new Polsovatel());

        }
    }
}