using Microsoft.Extensions.Logging;

namespace MauiAppmeuhotel
{
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
                    fonts.AddFont("PassionOne-Regular.ttf", "PassionOneRegular");
                    fonts.AddFont("PassionOne-Bold.ttf", "PassionOneBold");
                    fonts.AddFont("PassionOne-Black.ttf", "PassionOneBlack");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
