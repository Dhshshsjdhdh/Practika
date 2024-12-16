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
    public partial class Dtp : ContentPage
    {
        public Dtp()
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
            if (string.IsNullOrWhiteSpace(Name.Text))
            {
                await DisplayAlert("Ошибка", "Вы должны указать свое имя", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Adres.Text))
            {
                await DisplayAlert("Ошибка", "Вы должны указать адрес ДТП", "OK");
                return;
            }
            await DisplayAlert("Успех!", "Ваше сообщение зафиксировано! Ожидайте новое такси", "OK");
            await Navigation.PushAsync(new Polsovatel());
        }
    }
}