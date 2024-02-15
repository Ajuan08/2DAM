using Microsoft.Extensions.Logging;
using Practica10ControlGastos.MVVM.Model;
using Practica10ControlGastos.Repository;

namespace Practica10ControlGastos
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<BaseRepository<Transaccion>>();

            return builder.Build();
        }
    }
}
