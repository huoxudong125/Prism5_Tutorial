using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    public class Address : EntityBase
    {
        /// <summary>
        /// Holds a street address.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Holds a city name.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Holds a state name.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Holds a zip code.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Holds the country name.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.MediumStringLength</para>
        /// </summary>
        public string Country { get; set; }
    }
}