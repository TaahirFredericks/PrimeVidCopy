using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyFirstMauiApplication
{
    public partial class MainPage : ContentPage
    {
      
        
        // Launcher.OpenAsync is provided by Essentials.
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));


        public MainPage()
        {

            InitializeComponent();
            Routing.RegisterRoute("SignPage", typeof(SignPage));
            {
                InitializeComponent();
                BindingContext = this;
            }
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("SignPage");
        }

        //private void Button_Clicked(object sender, EventArgs e)

        

        
    }

}
