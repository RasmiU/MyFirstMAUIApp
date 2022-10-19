namespace MyFirstApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		Routing.RegisterRoute("newpage", typeof(NewPage1));
		Routing.RegisterRoute(nameof(Frame2), typeof(Frame2));
		Routing.RegisterRoute(nameof(SchedulePage), typeof(SchedulePage));
		Routing.RegisterRoute(nameof(Frame4), typeof(Frame4));
		Routing.RegisterRoute(nameof(Frame5), typeof(Frame5));
		return builder.Build();
	}
}
