using System.Collections.Generic;

namespace PennyWatch.Entities
{
    public class AccountType : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User friendly name for the account type.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Indicates if the account can have negative balance, such as credit cards.
        /// <para>Required.</para>
        /// </summary>
        public bool CanBeNegative { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}