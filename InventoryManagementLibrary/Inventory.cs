using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace InventoryManagementLibrary
{
    public class Inventory
    {
        BindingList<Product> Products = new BindingList<Product>();
        BindingList<Part> AllParts = new BindingList<Part>();
        List<int> PartIDs = new List<int>();
        
        
        
        public void AddProduct(Product product) {
            Products.Add(product);
        }

        public BindingList<Part> getPartsList()
        {
            return AllParts;
        }

        public BindingList<Product> getProductList()
        {
            return Products;
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

        public bool DeletePart(Part part) {
            return true;
        }

        //public Part LookupPart(int partID) { }

        public void UpdatePart(int partID, Part part) { }

        public int AssignPartID()
        {
            Random randPartNumber = new Random();
            int assignedPartNumber = randPartNumber.Next(1000, 99999);

            //foreach (int id in PartIDs)
            //{
            //    if (assignedPartNumber == PartIDs.IndexOf(id))
            //    {
            //        assignedPartNumber = randPartNumber.Next(1000, 99999);
            //    }
            //}
            
            PartIDs.Add(assignedPartNumber);

            return assignedPartNumber;
        }
    }
}
