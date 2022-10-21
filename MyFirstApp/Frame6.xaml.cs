namespace MyFirstApp;

public partial class Frame6 : ContentPage
{
	public Frame6()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(Frame7));
	}
}