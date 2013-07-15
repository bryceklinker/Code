using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Code.Domain.SearchPlayers;
using Code.Domain.SearchPlayers.Boundaries;
using Code.Presentation.WPF.Controllers;
using Code.Presentation.WPF.EventAggregators;
using Code.Presentation.WPF.ViewModels;
using Ninject;

namespace Code.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var kernel = new StandardKernel();

            kernel.Bind<EventAggregator>().To<EventAggregatorImp>().InSingletonScope();
            kernel.Bind<SearchPlayersProducerBoundary>().To<SearchPlayersInteractor>();
            kernel.Bind<SearchPlayersConsumerBoundary>().To<SearchPlayersViewModel>().InSingletonScope();

            kernel.Bind<SearchPlayersController>().ToSelf().InSingletonScope();
            kernel.Bind<MainViewModel>().ToSelf().InSingletonScope();

            MainWindow = kernel.Get<MainWindow>();
            MainWindow.Show();
            kernel.Get<EventAggregator>().Publish<SelectionViewModel>(kernel.Get<SearchPlayersViewModel>());
        }
    }
}
