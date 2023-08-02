using Microsoft.Extensions.Logging;
using Navegacion_V1._3.Helpers;

namespace Navegacion_V1._3;

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
		builder.Services.AgregarDependencias();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
