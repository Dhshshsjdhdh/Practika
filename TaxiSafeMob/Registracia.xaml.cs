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
    public partial class Registracia : ContentPage
    {
        public Registracia()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Reg_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text))
            {
                await DisplayAlert("Ошибка", "Имя не может быть пустым", "OK");
                return;
            }
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                await DisplayAlert("Ошибка", "Логин не может быть пустым", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                await DisplayAlert("Ошибка", "Пароль не может быть пустым", "OK");
                return;
            }

            await DisplayAlert("Успех", "Вы успешно зарегистрировались", "OK");
            await Navigation.PushAsync(new MainPage());
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}