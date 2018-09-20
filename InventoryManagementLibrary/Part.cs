using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementLibrary
{
    public abstract class Part : Inventory
    {
        int partID { get; set; }
        string name { get; set; }
        double price { get; set; }
        int inStock { get; set; }
        int min { get; set; }
        int max { get; set; }
    }
}
