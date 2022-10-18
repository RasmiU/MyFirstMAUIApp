namespace MyFirstApp;

public partial class SchedulePage : ContentPage
{
	public SchedulePage()
	{
		InitializeComponent();
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"/{nameof(Frame4)}");
	}
}