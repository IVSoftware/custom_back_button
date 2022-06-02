using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace custom_back_button
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            BackButtonCommand = new Command(BackButtonAction);
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
        public Command BackButtonCommand { get; }

        private async void BackButtonAction()
        {
            await MainPage.DisplayAlert("Message from button", "It worked", "OK");
        }

        public async void OnBackButtonPressed(object sender, EventArgs e)
        {
            // This pop up will be the test.
            await MainPage.DisplayAlert("Message from button", "It worked", "OK");
        }
    }
}
