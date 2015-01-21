using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Practices.Prism.Mvvm;
using PennyWatch.DataModule.Interfaces;
using PennyWatch.Entities;

namespace PennyWatch.AccountModule.ViewModels
{
    public class AccountListViewModel : BindableBase
    {
        public ObservableCollection<Account> Accounts { get; set; }

        public AccountListViewModel(IDALFacade dalFacade)
        {
            
           var unitOfWork = dalFacade.GetUnitOfWork();

            var allaccounts = unitOfWork.AccountRepo.GetByQuery(null, q => q.OrderBy(a => a.Name));
            Accounts = new ObservableCollection<Account>(allaccounts);
        }
    }
}