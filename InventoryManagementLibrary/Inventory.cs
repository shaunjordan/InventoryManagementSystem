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
        public void AddProduct(Product product) {
            Products.Add(product);
            
        }

        public List<Part> getPartsList()
        {
            return AllParts;
        }

        public bool RemoveProduct(int productID) {

            bool itemRemoved = false;
            Products.RemoveAt(1);
            itemRemoved = true;

            return itemRemoved;
        }

        //public Product LookupProduct(int productID)
        //{
        //    foreach (var item in Products)
        //    {
        //        if (Products.Find(Product.productID))
        //        {
        //            Product.
        //        }
        //    }
        //}

        public void UpdateProudct(int productID, Product product) { }

        public void AddPart(Part part) {
            AllParts.Add(part);
        }

        //public bool DeletePart(Part part) { }

        //public Part LookupPart(int partID) { }

        public void UpdatePart(int partID, Part part) { }
    }
}
