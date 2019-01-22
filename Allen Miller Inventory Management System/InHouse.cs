using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allen_Miller_Inventory_Management_System
{
    public class InHouse : Part
    {
        //Private
        private int machineID;


        //Public
        public int MachineID { get; set; }


        //Constructors
        public InHouse()
        { }

        public InHouse(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public InHouse(int partID, string name, decimal price, int inStock, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
