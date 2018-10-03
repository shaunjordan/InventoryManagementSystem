using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementLibrary
{
    public class Inhouse : Part
    {
        /// <summary>
        /// Indicates the origin of inhouse parts
        /// </summary>
        [DisplayName("Machine ID")]
        public int machineID { get; set; }
    }
}
