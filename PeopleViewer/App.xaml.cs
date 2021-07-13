using System.Windows;
using PeopleViewer.Presentation;
using PersonDataReader.Service;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObjects();
            Application.Current.MainWindow.Title = "With Dependency Injection";
            Application.Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            var reader = new ServiceReader();
            var viewModel = new PeopleViewModel(reader);
            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
