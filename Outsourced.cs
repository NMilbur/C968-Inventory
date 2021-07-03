using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMilburn_InventoryApp
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, int inStock, decimal price, int max, int min, string companyName)
        {
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }

        public Outsourced(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
    }
}
