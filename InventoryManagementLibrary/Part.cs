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
        [DisplayName("Part ID")]
        public int partID { get; set; }

        [DisplayName("Part Name")]
        public string name { get; set; }

        [DisplayName("Price/Cost")]
        public double price { get; set; }

        [DisplayName("In Stock")]
        public int inStock { get; set; }

        [Browsable(false)]
        public int min { get; set; }

        [Browsable(false)]
        public int max { get; set; }
    }
}
