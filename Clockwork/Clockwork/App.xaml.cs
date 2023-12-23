using Clockwork;
using Xamarin.Forms;

namespace Clockwork
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Установка главной страницы
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
      
        }

        protected override void OnResume()
        {
         
        }
    }
}

