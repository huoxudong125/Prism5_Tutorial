using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    public class PhoneNumber : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Phone number.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string Number { get; set; }


        /// <summary>
        /// Phone number description.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string Description { get; set; }
    }
}