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
        /// <summary>
        /// List of all Product objects.
        /// </summary>
        BindingList<Product> Products = new BindingList<Product>();

        /// <summary>
        /// List of all Part objects.
        /// </summary>
        BindingList<Part> AllParts = new BindingList<Part>();

        /// <summary>
        /// Adds Product object to the Products BindingList.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product) {
            Products.Add(product);
        }

        /// <summary>
        /// Returns the list of Part objects.
        /// </summary>
        /// <returns></returns>
        public BindingList<Part> GetPartsList()
        {
            return AllParts;
        }

        /// <summary>
        /// Returns the list of Product objects.
        /// </summary>
        /// <returns></returns>
        public BindingList<Product> GetProductList()
        {
            return Products;
        }

        /// <summary>
        /// Removes a Product object from the Products BindingList.
        /// </summary>
        /// <param name="product"></param>
        /// <returns>
        /// Returns true on removal of Product object.
        /// </returns>
        public bool RemoveProduct(Product product)
        {
            Products.Remove(product);
            return true;
        }

        /// <summary>
        /// Finds a Product object in the Products list (using product id).
        /// </summary>
        /// <param name="searchVal"></param>
        /// <returns>
        /// Returns the Product object.
        /// </returns>
        public Product LookupProduct(int searchVal)
        {
            Product searchedProduct = Products.SingleOrDefault(obj => obj.productID == searchVal);
            return searchedProduct;
        }

        /// <summary>
        /// Finds a Product object in the Products list (using substring).
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns>
        /// Returns the Product object.
        /// </returns>
        public Product LookupProduct(string searchTerm)
        {
            Product searchedProduct = Products.FirstOrDefault(obj => obj.name.ToLower().Contains(searchTerm));
            return searchedProduct;
        }

        /// <summary>
        /// Updates the Product object in the Products BindingList.
        /// </summary>
        /// <param name="productIndex"></param>
        /// <param name="product"></param>
        public void UpdateProduct(int productIndex, Product product)
        {
            Products.RemoveAt(productIndex);
            Products.Insert(productIndex, product);
        }

        /// <summary>
        /// Adds a Part object to the AllParts BindingList.
        /// </summary>
        /// <param name="part"></param>
        public void AddPart(Part part) {
            AllParts.Add(part);
        }

        /// <summary>
        /// Removes a Part object from the AllParts BindingList.
        /// </summary>
        /// <param name="part"></param>
        /// <returns>
        /// Returns true on Part removal.
        /// </returns>
        public bool DeletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        /// <summary>
        /// Finds a Part object in the AllParts BindingList (using part id).
        /// </summary>
        /// <param name="searchVal"></param>
        /// <returns>
        /// Returns a Part object.
        /// </returns>
        public Part LookupPart(int searchVal)
        {
            Part searchedPart = AllParts.SingleOrDefault(obj => obj.partID == searchVal);
            return searchedPart;
        }

        /// <summary>
        /// Finds a Part object in the AllParts BindingList (using substring).
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns>
        /// Returns a Part object.
        /// </returns>
        public Part LookupPart(string searchTerm)
        {
            Part searchedPart = AllParts.FirstOrDefault(obj => obj.name.ToLower().Contains(searchTerm));
            return searchedPart;
        }

        /// <summary>
        /// Updates the Part object in the AllParts BindingList.
        /// </summary>
        /// <param name="partIndex"></param>
        /// <param name="part"></param>
        public void UpdatePart(int partIndex, Part part)
        {
            AllParts.RemoveAt(partIndex);
            AllParts.Insert(partIndex, part);
        }

        /// <summary>
        /// Assigns an id number to a Part or Product object
        /// using a pseudo-random number.
        /// </summary>
        /// <returns>
        /// An integer designated as a Part or Product id number.
        /// </returns>
        public int AssignID()
        {
            Random randPartNumber = new Random();
            int assignedPartNumber = randPartNumber.Next(1000, 99999);

            return assignedPartNumber;
        }
    }
}
