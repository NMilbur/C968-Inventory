using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMilburn_InventoryApp
{
    public class Product
    {
        public Product(int productID, string name, decimal price, int inStock, int max, int min) {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Product(string name, decimal price, int inStock, int max, int min)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part) {
            AssociatedParts.Add(part);
        }
        
        public bool removeAssociatedPart(int partID) {
            int associatedIndex = getAssociatedIndex(partID);

            AssociatedParts.Remove(AssociatedParts[associatedIndex]);

            return true;
        }

        public Part lookupAssociatedPart(int partID) {
            int associatedIndex = getAssociatedIndex(partID);

            return (associatedIndex != -1) ? AssociatedParts[associatedIndex] : null;
        }

        private int getAssociatedIndex(int partID) {
            for (int i = 0; i < AssociatedParts.Count; i++) {
                if (AssociatedParts[i].PartID == partID) {
                    return i;
                }
            }

            return -1;
        }
    }
}
