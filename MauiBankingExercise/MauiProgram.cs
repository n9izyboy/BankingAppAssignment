using MauiBankingExercise.Services;
using MauiBankingExercise.ViewModels;
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
            builder.Services.AddSingleton<BankingSeeder>();

    		builder.Logging.AddDebug();


            builder.Services.AddSingleton<MauiBankingExercise.Services.BankingDataBaseServices>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.AllBankViewModels>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.BankViewModel>();
            builder.Services.AddTransient<MauiBankingExercise.Views.CustomerSelectionScreenView>();
            builder.Services.AddSingleton<MauiBankingExercise.Views.AccountDetails>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.CustomerSelectionScreenViewModel>();
            builder.Services.AddSingleton<MauiBankingExercise.Views.CustomerDashBoard>();
            builder.Services.AddSingleton<MauiBankingExercise.ViewModels.CustomerDashBoardViewModel>();
            builder.Services.AddSingleton<MauiBankingExercise.Views.TransactionScreen>();


#endif

            return builder.Build();
        }
    }
}
