using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementLibrary
{
    public class Product : Inventory
    {
        List<Part> AssociatedParts;

        int productID { get; set; }
        string name { get; set; }
        double price { get; set; }
        int inStock { get; set; }
        int min { get; set; }
        int max { get; set; }

        public void AddAssociatedPart(part) { }
        public bool RemoveAssociatedPart(int) { }
        public Part LookupAssociatedPart(int) { }
    }
}
