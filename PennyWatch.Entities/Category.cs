using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch.Entities
{
    /// <summary>
    /// Representes a category for transactions account in the application. Inherits from <see cref="EntityBase"/>.
    /// </summary>
    public class Category : EntityBase
    {
        /// <summary>
        /// Primary Key.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Category Name.
        /// <para>Required.</para>
        /// <para>Max Length: Settings.Default.ShortStringLength</para>
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Main Category identifier.
        /// <para>Required.</para>
        /// </summary>
        public bool IsMainCategory { get; set; }

        /// <summary>
        /// Parent category if this is a sub category.
        /// <para>Required.</para>
        /// </summary>
        public virtual Category ParentCategory { get; set; }

        /// <summary>
        /// Notes about the account.
        /// <para>Not Required.</para>
        /// <para>Max Length: Settings.Default.LongStringLength</para>
        /// </summary>
        public string Comment { get; set; }

        public virtual ICollection<Category> SubCategories { get; set; }
    }
}