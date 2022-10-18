namespace MyFirstApp;

public partial class Frame2 : ContentPage
{
	public Frame2()
	{
		InitializeComponent();
	}

	private void ScheduleButton_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(SchedulePage));
	}
}