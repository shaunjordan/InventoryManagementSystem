using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagementLibrary
{
    public class Inventory
    {
        BindingList<Product> Products = new BindingList<Product>();
        BindingList<Part> AllParts = new BindingList<Part>();

        public void AddProduct(Product product) {
            Products.Add(product);
        }

        public BindingList<Part> GetPartsList()
        {
            return AllParts;
        }

        public BindingList<Product> GetProductList()
        {
            return Products;
        }

        public bool RemoveProduct(Product product)
        {
            Products.Remove(product);
            return true;
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

        public void UpdateProduct(int productID, Product product)
        {

        }

        public void AddPart(Part part) {
            AllParts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        //public Part LookupPart(int searchVal)
        //{
        //    AllParts.SingleOrDefault
        //}

        public void UpdatePart(int partIndex, Part part)
        {
            AllParts.RemoveAt(partIndex);
            AllParts.Insert(partIndex, part);
        }

        public int AssignID()
        {
            Random randPartNumber = new Random();
            int assignedPartNumber = randPartNumber.Next(1000, 99999);

            return assignedPartNumber;
        }
    }
}
