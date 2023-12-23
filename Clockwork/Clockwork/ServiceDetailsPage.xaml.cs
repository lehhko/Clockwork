using System;
using Xamarin.Forms;
using Clockwork;
using Xamarin.Essentials;

namespace Clockwork
{
    
    public partial class ServiceDetailsPage : ContentPage
    {
        private MainPage mainPage;
        private string serviceName; 

        // Конструктор класса
        public ServiceDetailsPage(string serviceName, MainPage mainPage)
        {
            InitializeComponent();
            this.serviceName = serviceName;
            this.mainPage = mainPage;
        }

        // Обработчик события нажатия кнопки "Записаться на услугу"
        private void BookAppointmentButton_Clicked(object sender, EventArgs e)
        {
            // Получение данных из пользовательского ввода
            string name = nameEntry.Text;
            string phone = phoneEntry.Text;
            DateTime selectedDate = datePicker.Date + timePicker.Time;
            string selectedAddress = addressPicker.SelectedItem as string;

            // Отображение диалогового окна с подтверждением записи на услугу
            DisplayAlert("Успешно!", $"Вы записаны на услугу {serviceName}.\nДата и время: {selectedDate}\nИмя: {name}\nТелефон: {phone}\nАдрес: {selectedAddress}", "OK");
        }

        // Обработчик события нажатия кнопки "Перейти на страницу HisPage"
        private async void GoToHisPage_Clicked(object sender, EventArgs e)
        {
            // Проверка, что данные введены перед переходом на HisPage
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(phoneEntry.Text))
            {
                // Сохранение введенных данных в классе HData
                HData.Instance.Name = nameEntry.Text;
                HData.Instance.Phone = phoneEntry.Text;
                HData.Instance.DateTime = datePicker.Date + timePicker.Time;
                HData.Instance.Address = addressPicker.SelectedItem as string;

                showDataButton.IsEnabled = false; // Отключение кнопки "Показать данные"

                // Переход на страницу HisPage
                await Navigation.PushAsync(new HisPage());

                showDataButton.IsEnabled = true; // Включение кнопки "Показать данные"
            }
            else
            {
                // Вывод сообщения об ошибке, если данные не введены
                DisplayAlert("Ошибка", "Введите имя и телефон перед переходом на страницу", "OK");
            }
        }

        // Обработчик события нажатия кнопки "Назад"
        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            // Переход на главную страницу
            await Navigation.PushAsync(new MainPage());
        }
    }
}
