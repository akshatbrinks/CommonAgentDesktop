using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace CommonAgentDesktop.App
{
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
                })
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }



        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
            //mauiAppBuilder.Services.AddSingleton<IAuthService, AuthService>();
            //mauiAppBuilder.Services.AddSingleton<IMiscService, MiscService>();
            //mauiAppBuilder.Services.AddSingleton<IConfigurationService, ConfigurationService>();
            //mauiAppBuilder.Services.AddSingleton<IConfigCatService, ConfigCatService>();
            //mauiAppBuilder.Services.AddSingleton<INetworkService, NetworkService>();

            //mauiAppBuilder.Services.AddSingleton<IOfferEngineAPIService, OfferEngineAPIService>();
            //mauiAppBuilder.Services.AddSingleton<IMasAPIService, MasAPIService>();
            //mauiAppBuilder.Services.AddSingleton<ICadAPIService, CadAPIService>();
            //mauiAppBuilder.Services.AddSingleton<IRulesEngineAPIService, RulesEngineAPIService>();
            //mauiAppBuilder.Services.AddSingleton<IHelperAPIService, HelperAPIService>();
            //mauiAppBuilder.Services.AddSingleton<IOrchestrationService, OrchestrationService>();
            //mauiAppBuilder.Services.AddSingleton(typeof(IAppLogger<>), typeof(AppLogger<>));
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<LoginViewModel>();
            //mauiAppBuilder.Services.AddTransient<HomeViewModel>();
            mauiAppBuilder.Services.AddTransient<MovesViewModel>();
            mauiAppBuilder.Services.AddTransient<VoziqViewModel>();
            mauiAppBuilder.Services.AddTransient<JobSchedulingViewModel>();
            //mauiAppBuilder.Services.AddTransient<SupportCenterViewModel>();
            mauiAppBuilder.Services.AddTransient<CustomerLookupViewModel>();
            //mauiAppBuilder.Services.AddTransient<AlarmViewModel>();
            mauiAppBuilder.Services.AddTransient<MyAccountViewModel>();
            //mauiAppBuilder.Services.AddTransient<CrestaViewModel>();
            //mauiAppBuilder.Services.AddTransient<PaymentViewModel>();
            mauiAppBuilder.Services.AddTransient<AppShellViewModel>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<LoginView>();
            //mauiAppBuilder.Services.AddTransient<HomeView>();
            mauiAppBuilder.Services.AddTransient<VoziqView>();
            mauiAppBuilder.Services.AddTransient<MovesView>();
            mauiAppBuilder.Services.AddTransient<JobSchedulingView>();
            //mauiAppBuilder.Services.AddTransient<SupportCenterView>();
            //mauiAppBuilder.Services.AddTransient<PortalCoPilotView>();
            mauiAppBuilder.Services.AddTransient<CustomerLookup>();
            //mauiAppBuilder.Services.AddTransient<AlarmView>();
            mauiAppBuilder.Services.AddTransient<MyAccountView>();
            //mauiAppBuilder.Services.AddTransient<CustomerAttributeView>();
            //mauiAppBuilder.Services.AddTransient<CrestaView>();
            //mauiAppBuilder.Services.AddTransient<PaymentView>();
            return mauiAppBuilder;
        }
    }
}
