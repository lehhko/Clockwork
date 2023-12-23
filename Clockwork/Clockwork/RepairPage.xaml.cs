using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clockwork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RepairPage : ContentPage
    {
        // Задание стоимостей для различных услуг
        private decimal service1Cost = 490.0m;
        private decimal service2Cost = 490.0m;
        private decimal service3Cost = 1490.0m;
        private decimal service4Cost = 990.0m;

        private decimal totalCost = 0.0m; // Общая стоимость выбранных услуг

        // Конструктор класса
        public RepairPage()
        {
            InitializeComponent();
        }

        // Обработчик события переключения переключателей услуг
        private void ServiceSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            var serviceSwitch = (Switch)sender;

            if (serviceSwitch.IsToggled)
            {
                // Включен
                if (serviceSwitch == service1Switch)
                    totalCost += service1Cost;
                else if (serviceSwitch == service2Switch)
                    totalCost += service2Cost;
                else if (serviceSwitch == service3Switch)
                    totalCost += service3Cost;
                else if (serviceSwitch == service4Switch)
                    totalCost += service4Cost;
            }
            else
            {
                // Выключен
                if (serviceSwitch == service1Switch)
                    totalCost -= service1Cost;
                else if (serviceSwitch == service2Switch)
                    totalCost -= service2Cost;
                else if (serviceSwitch == service3Switch)
                    totalCost -= service3Cost;
                else if (serviceSwitch == service4Switch)
                    totalCost -= service4Cost;
            }

            // Обновить отображение общей стоимости
            totalCostLabel.Text = $"Общая стоимость: ${totalCost}";
        }

        // Обработчик события нажатия кнопки "Записаться"
        private async void BookAppointmentButton_Clicked(object sender, EventArgs e)
        {
            // Переход на страницу с формой онлайн записи
            await Navigation.PushAsync(new ServiceDetailsPage("Чистка", null));
        }

        // Обработчик события нажатия кнопки "Назад"
        private async void GoBack_Clicked(object sender, EventArgs e)
        {
            // Возврат на предыдущую страницу
            await Navigation.PopAsync();
        }
    }
}
