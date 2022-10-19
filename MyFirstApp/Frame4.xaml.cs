namespace MyFirstApp;

public partial class Frame4 : ContentPage
{
	public Frame4()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(Frame5));
	}
}