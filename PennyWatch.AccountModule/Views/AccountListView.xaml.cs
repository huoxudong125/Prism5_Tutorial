using System.Windows.Controls;
using Microsoft.Practices.Unity;
using PennyWatch.AccountModule.ViewModels;

namespace PennyWatch.AccountModule.Views
{
    /// <summary>
    /// Interaction logic for AccountListView.xaml
    /// </summary>
    public partial class AccountListView : UserControl
    {
        public AccountListView()
        {
            InitializeComponent();
        }

        [Dependency]
        public AccountListViewModel ViewModel
        {
            get { return DataContext as AccountListViewModel; }
            set { DataContext = value; }
        }
    }
}