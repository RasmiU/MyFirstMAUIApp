namespace MyFirstApp;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}


	private void GetStartedButton_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"/{nameof(Frame2)}");
	}
}