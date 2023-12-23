using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clockwork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesPage : ContentPage
    {


        public ServicesPage() 
        {
            InitializeComponent();
        }


        private async void RepairButton_Clicked(object sender, EventArgs e) //кнопка, ведущая на страницу ремонта
        {
            
            await Navigation.PushAsync(new RepairPage());
        }

        private async void PolishingButton_Clicked(object sender, EventArgs e) //кнопка, ведущая на страницу полировки
        {
            
            await Navigation.PushAsync(new PolishingPage());
        }

        private async void CleaningButton_Clicked(object sender, EventArgs e) //кнопка, ведущая на страницу чистки
        {
         
            await Navigation.PushAsync(new CleaningPage());
        }
    }
}
