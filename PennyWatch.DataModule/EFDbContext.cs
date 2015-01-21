using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PennyWatch.Entities;

namespace PennyWatch.DataModule
{
    /// <summary>
    /// Central class that handles database transactions.
    /// <para>Derived from <see cref="DbContext"/></para>
    /// </summary>
    internal class EFDbContext : DbContext
    {
        //_________________________________________________________________________________________

        #region Properties

        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Payee> Payees { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        #endregion

        //_________________________________________________________________________________________

        #region Constructors

        public EFDbContext()
        {
        }

        public EFDbContext(string databaseName)
            : base(databaseName)
        {
        }

        public EFDbContext(DbConnection connection, bool ownsConnection) :
            base(connection, contextOwnsConnection: ownsConnection)
        {
        }

        #endregion
    }
}