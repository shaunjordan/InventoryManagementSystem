using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementLibrary
{
    public abstract class Part : Inventory
    {
        public int partID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int inStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }
    }
}
