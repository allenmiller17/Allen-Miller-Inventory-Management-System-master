using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allen_Miller_Inventory_Management_System
{
    public abstract class Part
    {
        //Private
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int max;
        private int min;


        //Public
        public int PartID { get; set; }
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
