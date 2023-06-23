using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MAUIPopupNavigation.View;
using MAUIPopupNavigation.ViewModel;

namespace MAUIPopupNavigation;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		// Views
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<PageOneView>();


		// View Models
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<PageOneViewModel>();

		return builder.Build();
	}
}

