using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMilburn_InventoryApp
{
    public class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static List<Part> AllParts = new List<Part>();

        public static int PartIncrement { get; set; }
        public static int ProductIncrement { get; set; }

        public static void addProduct(Product newProduct) {
            Products.Add(newProduct);
        }

        public static bool removeProduct(int productID) {
            int productIndex = getProductIndex(productID);

            Products.Remove(Products[productIndex]);

            return true;
        }
        
        public static Product lookupProduct(int productID) {
            int productIndex = getProductIndex(productID);

            return (productIndex != -1) ? Products[productIndex] : null;
        }

        public static void updateProduct(int productID, Product product) {
            int productIndex = getProductIndex(productID);
            Product existingProduct = Products[productIndex];

            existingProduct.Name = product.Name;
            existingProduct.InStock = product.InStock;
            existingProduct.Price = product.Price;
            existingProduct.Max = product.Max;
            existingProduct.Min = product.Min;
        }

        public static void addPart(Part newPart) {
            AllParts.Add(newPart);
        }

        public static bool deletePart(int partID) {
            int partIndex = getPartIndex(partID);

            AllParts.Remove(AllParts[partIndex]);

            return true;
        }
        
        public static Part lookupPart(int partID) {
            int partIndex = getPartIndex(partID);

            return (partIndex != -1) ? AllParts[partIndex] : null;
        }

        public static void updatePart(int partID, Part part) {
            int partIndex = getPartIndex(partID);

            if (partIndex != -1)
            {
                if (part is Inhouse)
                {
                    updateInhousePart(partIndex, (Inhouse)part);

                }
                else
                {
                    updateOutsourcedPart(partIndex, (Outsourced)part);
                }
            }
        }

        private static void updateInhousePart(int partIndex, Inhouse inputPart) {
            Inhouse existingPart = (Inhouse)AllParts[partIndex];

            existingPart.Name = inputPart.Name;
            existingPart.InStock = inputPart.InStock;
            existingPart.Price = inputPart.Price;
            existingPart.Max = inputPart.Max;
            existingPart.Min = inputPart.Min;
            existingPart.MachineID = inputPart.MachineID;
        }

        private static void updateOutsourcedPart(int partIndex, Outsourced inputPart)
        {
            Outsourced existingPart = (Outsourced)AllParts[partIndex];

            existingPart.Name = inputPart.Name;
            existingPart.InStock = inputPart.InStock;
            existingPart.Price = inputPart.Price;
            existingPart.Max = inputPart.Max;
            existingPart.Min = inputPart.Min;
            existingPart.CompanyName = inputPart.CompanyName;
        }

    #region Helper Functions
        private static int getPartIndex(int partID)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    return i;
                }
            }

            return -1;
        }
        private static int getProductIndex(int productID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    return i;
                }
            }

            return -1;
        }
    #endregion
    }
}
