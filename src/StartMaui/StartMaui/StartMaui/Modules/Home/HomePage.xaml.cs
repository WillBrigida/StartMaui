using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace StartMaui.Modules.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}
