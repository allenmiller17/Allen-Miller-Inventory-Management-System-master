using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allen_Miller_Inventory_Management_System
{
    public class Outsourced : Part
    {
        //Private
        private string companyName;


        //Public
        public string CompanyName { get; set; }


        //Constructors
        public Outsourced()
        { }

        public Outsourced(int partID, string name, decimal price, int inStock, int max, int min)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
        }

        public Outsourced(int partID, string name, decimal price, int inStock, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
    }
}
