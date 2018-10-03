using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace InventoryManagementLibrary
{
    public class Outsourced : Part
    {
        /// <summary>
        /// Indicates the source of outsourced parts
        /// </summary>
        [DisplayName("Company Name")]
        public string companyName { get; set; }
    }
}
