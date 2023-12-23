using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Clockwork
{
    // Главная страница приложения
    public partial class MainPage : ContentPage
    {
        // Конструктор класса MainPage
        public MainPage()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки для перехода к странице выбора услуг
        private async void GoToServicesPage_Clicked(object sender, EventArgs e)
        {
            // Переход к странице выбора услуг (ServicesPage)
            await Navigation.PushAsync(new ServicesPage());
        }
    }
}
