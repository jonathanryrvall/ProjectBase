using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFProjectBase.Services;
using WPFProjectBase.ViewModel;

namespace WPFProjectBase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        public App()
        {
            //AppDomain currentDomain = AppDomain.CurrentDomain;
            //currentDomain.UnhandledException += UnhandledExceptionHandler;

            //Configuration = CreateConfiguration();
            Services = ConfigureServices();

            //SetLanguage();

            //_logger = Services.GetRequiredService<ILogger<App>>();
            //_logger.LogInformation("Application is starting...");

            //if (!_isDemo)
            //{
            //    // Fix: Force early creation of ZmqPublisher, it seems uncertain to publish messages immediately upon object creation
            //    Services.GetRequiredService<IPublisher>();
            //}

            this.InitializeComponent();
        }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Views
            services.AddSingleton<MainV>();


            // ViewModels
            services.AddSingleton<MainVM>();
       
            // Services
            services.AddSingleton<ConfigService>();
            services.AddSingleton<PathsService>();

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            App.Current.MainWindow = Services.GetRequiredService<MainV>();
            App.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            var mainV = Services.GetRequiredService<MainV>();
            mainV.Show();

            //var navigationService = Services.GetRequiredService<NavigationService>();
            //navigationService.Show(Navigation.Windows.MainView);

            //SetTheme();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
