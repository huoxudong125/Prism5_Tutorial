using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    public class Transaction : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; private set; }


        /// <summary>
        /// Date of the transaction.
        /// <para>Required.</para>
        /// </summary>
        public DateTime? Date { get; set; }


        /// <summary>
        /// Account id that the transaction belongs.
        /// <para>Required.</para>
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// The other end of the transaction.
        /// <para>Required.</para>
        /// </summary>
        public Payee OtherParty { get; set; }


        /// <summary>
        /// Amount of the transction.
        /// <para>Required.</para>
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Indicates if the transaction is a tranfer of funds to another account.
        /// <para>Required.</para>
        /// </summary>
        public bool IsTransfer { get; set; }


        /// <summary>
        /// Category of the transaction.
        /// <para>Required.</para>
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Comments about the transaction.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// ID of the receviving account if the transaction is a transfer.
        /// <para>Not Required.</para>
        /// </summary>
        public Account ReceivingAccount { get; set; }
    }
}