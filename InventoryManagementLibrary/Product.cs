using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementLibrary
{
    public class Product : Inventory
    {
        BindingList<Part> AssociatedParts;

        [DisplayName("Product ID")]
        public int productID { get; set; }

        [DisplayName("Product Name")]
        public string name { get; set; }

        [DisplayName("Price/Cost")]
        public double price { get; set; }

        [DisplayName("In Stock")]
        public int inStock { get; set; }

        [Browsable(false)]
        public int min { get; set; }

        [Browsable(false)]
        public int max { get; set; }

        //public void AddAssociatedPart(part) { }
        //public bool RemoveAssociatedPart(int) { }
        //public Part LookupAssociatedPart(int) { }
    }
}
