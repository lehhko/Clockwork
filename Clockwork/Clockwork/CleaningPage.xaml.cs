using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clockwork
{
    // Класс CleaningPage представляет страницу для выбора услуги по чистке часов.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CleaningPage : ContentPage
    {
        // Стоимость услуги чистки часового механизма
        private decimal service1Cost = 1490.0m;

        // Стоимость услуги полировки или замены стекла
        private decimal service2Cost = 990.0m;

        // Общая стоимость выбранных услуг
        private decimal totalCost = 0.0m;

        // Конструктор класса CleaningPage
        public CleaningPage()
        {
            InitializeComponent();
        }

        // Обработчик изменения состояния переключателя услуг
        private void ServiceSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            var serviceSwitch = (Switch)sender;

            // Обработка включения или выключения услуги
            if (serviceSwitch.IsToggled)
            {
                // Включена
                if (serviceSwitch == service1Switch)
                    totalCost += service1Cost;
                else if (serviceSwitch == service2Switch)
                    totalCost += service2Cost;
            }
            else
            {
                // Выключена
                if (serviceSwitch == service1Switch)
                    totalCost -= service1Cost;
                else if (serviceSwitch == service2Switch)
                    totalCost -= service2Cost;
            }

            // Обновить отображение общей стоимости
            totalCostLabel.Text = $"Общая стоимость: ${totalCost}";
        }

        // Обработчик нажатия кнопки записи на услугу
        private async void BookAppointmentButton_Clicked(object sender, EventArgs e)
        {
            // Переход на страницу с деталями выбранной услуги
            await Navigation.PushAsync(new ServiceDetailsPage("Чистка", null));
        }

        // Обработчик нажатия кнопки возврата
        private async void GoBack_Clicked(object sender, EventArgs e)
        {
            // Возвращение на предыдущую страницу
            await Navigation.PopAsync();
        }
    }
}
