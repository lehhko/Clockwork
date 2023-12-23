using Clockwork;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clockwork
{
    // Класс HisPage представляет страницу для отображения данных о предыдущей записи пользователя
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HisPage : ContentPage
    {
        // Конструктор класса HisPage
        public HisPage()
        {
            InitializeComponent();

            // Инициализация введенных данных пользователя
            nameLabel.Text = $"Имя: {HData.Instance.Name}";
            phoneLabel.Text = $"Телефон: {HData.Instance.Phone}";
            datetimeLabel.Text = $"Дата и время: {HData.Instance.DateTime}";
            addressLabel.Text = $"Адрес: {HData.Instance.Address}";
        }
    }
}
