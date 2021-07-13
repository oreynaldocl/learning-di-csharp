using Ninject;
using PeopleViewer.Common;
using PersonDataReader.CSV;
using PersonDataReader.Service;
using PersonReader.Caching;
using System.Windows;

namespace PeopleViewer.Ninject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IKernel Container = new StandardKernel();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Title = "With Dependency Injection - Ninject";
            Application.Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {

            Container.Bind<IPersonReader>().To<CSVReader>()
                .InSingletonScope();
        }

        private void ComposeObjects()
        {
            Application.Current.MainWindow = Container.Get<PeopleViewerWindow>();
        }
    }
}
