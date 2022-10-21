namespace MyFirstApp;

public partial class Frame5 : ContentPage
{
	public Frame5()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(Frame6));
	}
}