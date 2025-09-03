using Microsoft.Extensions.Logging;

namespace MauiBankingExercise
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


            builder.Services.AddSingleton<MauiBankingExercise.Services.BankingDataBaseServices>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.AllBankViewModels>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.BankViewModel>();
            builder.Services.AddTransient<MauiBankingExercise.Views.CustomerSelectionScreen>();
            builder.Services.AddSingleton<MauiBankingExercise.Views.AccountDetails>();
            

#endif

            return builder.Build();
        }
    }
}
