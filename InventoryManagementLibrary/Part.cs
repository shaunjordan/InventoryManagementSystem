using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementLibrary
{
    public abstract class Part : Inventory
    {
        /// <summary>
        /// Represents the unique id number of the part.
        /// </summary>
        [DisplayName("Part ID")]
        public int partID { get; set; }

        /// <summary>
        /// Represents the name of the part.
        /// </summary>
        [DisplayName("Part Name")]
        public string name { get; set; }

        /// <summary>
        /// Represents the price of the part.
        /// </summary>
        [DisplayName("Price/Cost"),]
        public double price { get; set; }

        /// <summary>
        /// Represents the available number of parts.
        /// </summary>
        [DisplayName("In Stock")]
        public int inStock { get; set; }

        /// <summary>
        /// Represents the minimum number
        /// of parts kept in stock.
        /// </summary>
        [Browsable(false)]
        public int min { get; set; }

        /// <summary>
        /// Represents the maximum number
        /// of parts kept in stock.
        /// </summary>
        [Browsable(false)]
        public int max { get; set; }
    }
}
