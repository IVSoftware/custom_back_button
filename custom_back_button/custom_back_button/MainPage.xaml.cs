using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace custom_back_button
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainPageBinding();
            InitializeComponent();
        }
    }
    class MainPageBinding
    {
        public MainPageBinding()
        {
            BackButtonPressedCommand = new Command(OnBackButtonPressed);
        }

        public ICommand BackButtonPressedCommand { get; private set; }
        private void OnBackButtonPressed(object o)
        {
            App.Current.MainPage.DisplayAlert("Message from button", "It worked", "OK");
        }
    }
}
