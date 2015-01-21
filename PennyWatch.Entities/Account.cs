using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    public class Account : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Account Name.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Financial Institution Name.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// Account No.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string AccountNo { get; set; }

        /// <summary>
        /// Account Type.
        /// <para>Required.</para>
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Account Activity Status.
        /// <para>Required.</para>
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Currency Name. Used for display only.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Currency Symbol.
        /// <para>Required.</para>
        /// <para>Length: 3</para>
        /// </summary>
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Account Opening Date.
        /// <para>Not Required.</para>
        /// <para>Nullable.</para>
        /// </summary>
        public DateTime? OpeningDate { get; set; }

        /// <summary>
        /// Account Closing Date.
        /// <para>Not Required.</para>
        /// <para>Nullable.</para>
        /// </summary>
        public DateTime? ClosingDate { get; set; }


        /// <summary>
        /// Initial Account Balance.
        /// <para>Required.</para>
        /// </summary>
        public decimal? OpeningBalance { get; set; }

        /// <summary>
        /// Current Account Balance. Calculated internally by the application.
        /// <para>Required.</para>
        /// </summary>
        public decimal? CurrentBalance { get; set; }

        /// <summary>
        /// Account Balance Limit. USed for credit accounts.
        /// <para>Not Required.</para>
        /// </summary>
        public decimal? LimitBalance { get; set; }


        /// <summary>
        /// Notes about the account.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.LongStringLength</para>
        /// </summary>
        public string Comment { get; set; }
    }
}