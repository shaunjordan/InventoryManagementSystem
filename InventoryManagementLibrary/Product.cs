using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementLibrary
{
    public class Product : Inventory
    {
        /// <summary>
        /// Represents a list of parts related to the product.
        /// </summary>
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
       
        /// <summary>
        /// Represents the unique id number of the product.
        /// </summary>
        [DisplayName("Product ID")]
        public int productID { get; set; }

        /// <summary>
        /// Represents the name of the product.
        /// </summary>
        [DisplayName("Product Name")]
        public string name { get; set; }

        /// <summary>
        /// Represents the price of the product.
        /// </summary>
        [DisplayName("Price/Cost")]
        public double price { get; set; }

        /// <summary>
        /// Represents the number of available products.
        /// </summary>
        [DisplayName("In Stock")]
        public int inStock { get; set; }

        /// <summary>
        /// Represents the minimum number of products
        /// kept in stock.
        /// </summary>
        [Browsable(false)]
        public int min { get; set; }

        /// <summary>
        /// Represents the maximum number of products
        /// kept in stock.
        /// </summary>
        [Browsable(false)]
        public int max { get; set; }

        /// <summary>
        /// Adds a part to the AssociatedParts BindingList.
        /// </summary>
        /// <param name="part">
        /// The selected part.
        /// </param>
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        /// <summary>
        /// Provides the full list of parts associated with a product.
        /// </summary>
        /// <returns>
        /// BindingList<Part> AssociatedParts
        /// </returns>
        public BindingList<Part> GetAssociatedParts()
        {
            return AssociatedParts;
        }

        /// <summary>
        /// Removes a part associated with the product.
        /// </summary>
        /// <param name="partID"></param>
        /// <returns>
        /// Boolean value on removal.
        /// </returns>
        public bool RemoveAssociatedPart(int partID)
        {
            Part partToRemove = AssociatedParts.FirstOrDefault(part => part.partID == Convert.ToInt32(partID));
            AssociatedParts.Remove(partToRemove);
            return true;
        }

        /// <summary>
        /// Finds the part associated with the product (using part id number).
        /// </summary>
        /// <param name="searchVal"></param>
        /// <returns>
        /// Part object from list of associated parts.
        /// </returns>
        public Part LookupAssociatedPart(int searchVal)
        {
            Part searchedPart = AssociatedParts.SingleOrDefault(obj => obj.partID == searchVal);
            return searchedPart;
        }
        /// <summary>
        /// Finds the part associated with the product (using substring).
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns>
        /// Part object from list of associated parts.
        /// </returns>
        public Part LookupAssociatedPart(string searchTerm)
        {
            Part searchedPart = AssociatedParts.FirstOrDefault(obj => obj.name.ToLower().Contains(searchTerm));
            return searchedPart;
        }
    }
}
