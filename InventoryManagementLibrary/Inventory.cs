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

        public Product LookupProduct(int searchVal)
        {
            Product searchedProduct = Products.SingleOrDefault(obj => obj.productID == searchVal);
            return searchedProduct;
        }

        public Product LookupProduct(string searchTerm)
        {
            Product searchedProduct = Products.FirstOrDefault(obj => obj.name.ToLower().Contains(searchTerm));
            return searchedProduct;
        }

        public void UpdateProduct(int productIndex, Product product)
        {
            Products.RemoveAt(productIndex);
            Products.Insert(productIndex, product);
        }

        public void AddPart(Part part) {
            AllParts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        public Part LookupPart(int searchVal)
        {
            Part searchedPart = AllParts.SingleOrDefault(obj => obj.partID == searchVal);
            return searchedPart;
        }

        public Part LookupPart(string searchTerm)
        {
            Part searchedPart = AllParts.FirstOrDefault(obj => obj.name.ToLower().Contains(searchTerm));
            return searchedPart;
        }

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
