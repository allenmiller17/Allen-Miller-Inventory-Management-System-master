using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Allen_Miller_Inventory_Management_System
{
   public class Product
    {
        //Binding List
        public BindingList<Part> AssociatedParts = new BindingList<Part>();


        //Private
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int max;
        private int min;


        //Public
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }



        //Constructors

        public Product()
        { }

        public Product(int productID, string name, decimal price, int inStock, int max, int min)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
        }


        //Add Part
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }


        //Remove Part
        
       public bool RemoveAssociatedPart(int partID)
        {
            AssociatedParts.AllowRemove = true;
            bool finished = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return finished = true;
                }
                else
                {
                    finished = false;
                }
            }
            return finished;
        }
       


        //Lookup Part
       public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
                else
                {
                    MessageBox.Show("No Part Found!/nPlease Try Again!");
                }
            }
            InHouse emptyInHouse = new InHouse();
            return emptyInHouse;
        }


    }
}
