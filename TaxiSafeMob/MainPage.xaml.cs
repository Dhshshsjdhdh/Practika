using System;
using Xamarin.Forms;

namespace TaxiSafeMob
{
    public partial class MainPage : ContentPage
    {
        //DataBaseConfig dataBase = new DataBaseConfig();
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private async void Reg_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Registracia());
        }

        private async void Avtor_Clicked(object sender, EventArgs e)
        {
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

            string login = Login.Text;
            string password = Password.Text;

            //// Использование параметризированного запроса для предотвращения SQL-инъекций
            //string query = "SELECT Name FROM Polsovateli WHERE Login = @login AND Password = @password;";

            //try
            //{
            //    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            //    {
            //        command.Parameters.AddWithValue("@login", login);
            //        command.Parameters.AddWithValue("@password", password);

            //        dataBase.openConnection();

            //        // Выполнение запроса и получение результата
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                // Получение имени пользователя
            //                string name = reader["Name"].ToString();

            //                DataBaseConfig.Name = name;
            //                await Navigation.PushAsync(new Polsovatel());



            //            }
            //            else
            //            {
            //                await DisplayAlert("Ошибка", "Неверный логин или пароль", "OK");
            //            }
            //        }
            //    }
            //}

            //finally
            //{
            //    // Закрытие соединения, если оно открыто
            //    if (dataBase.getConnection().State == ConnectionState.Open)
            //    {
            //        dataBase.closeConnection();
            //    }
            //}
            await Navigation.PushAsync(new Polsovatel());


        }
    }
}
