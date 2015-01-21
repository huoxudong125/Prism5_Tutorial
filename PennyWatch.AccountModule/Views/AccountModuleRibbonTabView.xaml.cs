using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using PennyWatch.AccountModule.ViewModels;
using PennyWatch.CommonModule.BaseTypes;
using System.Windows.Controls.Ribbon;

namespace PennyWatch.AccountModule.Views
{
    /// <summary>
    /// Interaction logic for AccountModuleRibbonTabView.xaml
    /// </summary>
    [ViewSortHint("1")]
    public partial class AccountModuleRibbonTabView : RibbonTabViewBase
    {
        public AccountModuleRibbonTabView()
        {
            _ViewName = Settings.Default.RibbonTabViewName;
            _PairedWorkspaceViewName = Settings.Default.WorkspaceViewName;
            InitializeComponent();
        }

        [Dependency]
        public AccountModuleRibbonTabViewModel ViewModel {
            get { return DataContext as AccountModuleRibbonTabViewModel; }
            set { DataContext = value; }
        }
    }
}