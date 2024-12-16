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
    public partial class Otziv : ContentPage
    {
        public Otziv()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Polsovatel());
        }

        private async void Otpravit_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Comment.Text))
            {
                await DisplayAlert("Ошибка", "Ваш комментарий не может быть пустым", "OK");
                return;
            }
            await Navigation.PushAsync(new Polsovatel());
        }
    }
}