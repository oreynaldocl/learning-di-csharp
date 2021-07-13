using System.Windows;
using PeopleViewer.Presentation;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for PeopleViewerWindow.xaml
    /// </summary>
    public partial class PeopleViewerWindow : Window
    {
        readonly PeopleViewModel viewModel;

        public PeopleViewerWindow(PeopleViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            DataContext = viewModel;
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RefreshPeople();
            ShowRepositoryType();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearPeople();
            ClearRepositoryType();
        }

        private void ShowRepositoryType()
        {
            RepositoryTypeTextBlock.Text = viewModel.DataReaderType;
        }

        private void ClearRepositoryType()
        {
            RepositoryTypeTextBlock.Text = string.Empty;
        }
    }
}
