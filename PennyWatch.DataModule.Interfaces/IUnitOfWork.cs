using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PennyWatch.Entities;

namespace PennyWatch.DataModule.Interfaces
{
    /// <summary>
    /// Interface to define contract for the unit of work class.
    /// </summary>
    public interface IUnitOfWork
    {
        IRepository<AccountType> AccountTypeRepo { get; }
        IRepository<Account> AccountRepo { get; }
        IRepository<Category> CategoryRepo { get; }
        IRepository<Payee> PayeeRepo { get; }
        IRepository<PhoneNumber> PhoneNumberRepo { get; }
        IRepository<Transaction> TransactionRepo { get; }

        /// <summary>
        /// Used to save the changes to the underlying data store.
        /// </summary>
        void Commit();
    }
}