using Microsoft.Maui.Controls;
using StartMaui.Modules.BaseVM;
using StartMaui.Modules.Home;
using System.Windows.Input;

namespace StartMaui.Modules.Login
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginRequest LoginRequest { get; set; }

        public LoginViewModel()
        {
            Title = "Login";
            LoginRequest = new LoginRequest();
        }

        public ICommand LoginCommand => new Command(async () =>
        {
           if (!LoginRequest.IsValid)
           {
               await App.Current.MainPage.DisplayAlert(Title, $"\n{LoginRequest.MessagesError[LoginRequest.Message]}", "OK");
               return;
           }

           await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        });
    }
}
