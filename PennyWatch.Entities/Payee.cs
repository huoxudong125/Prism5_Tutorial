using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    public class Payee : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Address of the payee as a complex type.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Address of the payee as a complex type.
        /// <para>Required.</para>
        /// </summary>
        public Address Address { get; set; }


        /// <summary>
        /// Holds a collection of phone numbers.
        /// <para>Not Required.</para>
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Website { get; set; }


        /// <summary>
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.LongStringLength</para>
        /// </summary>
        public string Memo { get; set; }
    }
}