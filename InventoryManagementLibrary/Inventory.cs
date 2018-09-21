using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementLibrary
{
    public class Inventory
    {
        List<Product> Products = new List<Product>();
        List<Part> AllParts = new List<Part>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public void AddProduct(Product product) { }

        public bool RemoveProduct(int productID) {
            return true;
        }

        //public Product LookupProduct(int productID) {
           
        //}

        public void UpdateProudct(int productID, Product product) { }

        public void AddPart(Part part) { }

        //public bool DeletePart(Part part) { }

        //public Part LookupPart(int partID) { }

        public void UpdatePart(int partID, Part part) { }
    }
}
