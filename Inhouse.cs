using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMilburn_InventoryApp
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(string name, int inStock, decimal price, int max, int min, int machineID)
        {
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }

        public Inhouse(int partID, string name, int inStock, decimal price, int max, int min, int machineID) {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
