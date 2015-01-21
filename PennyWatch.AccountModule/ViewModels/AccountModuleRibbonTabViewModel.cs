using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using PennyWatch.AccountModule.Views;

namespace PennyWatch.AccountModule.ViewModels
{
    public class AccountModuleRibbonTabViewModel
    {
        private IRegionManager _regionManager;

        public AccountModuleRibbonTabViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            OpenAccountListViewCommand =
                new DelegateCommand(
                    () => regionManager.RegisterViewWithRegion("AccountWorkspaceRegionName", typeof (AccountListView)),
                    () => true);

            OnShowMessageboxCommand = new DelegateCommand(() => MessageBox.Show("Clicked me"), () => true);
        }

        public DelegateCommand OpenAccountListViewCommand { get; private set; }

        public DelegateCommand OnShowMessageboxCommand { get; private set; }
    }
}