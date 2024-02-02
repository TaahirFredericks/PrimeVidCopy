namespace MyFirstMauiApplication;

public partial class SignPage : ContentPage
{
	public SignPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("GrandHomePage", typeof(GrandHomePage));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("GrandHomePage");
    }






}