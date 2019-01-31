using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Allen_Miller_Inventory_Management_System
{
    class Inventory
    {
        //BindingList
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void CreateList()
        {
            //Fix Price Conversion
            Product tempProduct1 = new Product(1, "Bike", 200.00m, 50, 500, 10);
            Product tempProduct2 = new Product(2, "Scooter", 300.00m, 60, 600, 20);
            Product tempProduct3 = new Product(3, "Skateboard", 400.00m, 70, 700, 30);
            Product tempProduct4 = new Product(4, "Trike", 500.00m, 80, 800, 40);
            Product tempProduct5 = new Product(5, "Unicycle", 600.00m, 90, 900, 50);
            Product tempProduct6 = new Product(6, "Roller Skates", 700.00m, 100, 1000, 60);

            Products.Add(tempProduct1);
            Products.Add(tempProduct2);
            Products.Add(tempProduct3);
            Products.Add(tempProduct4);
            Products.Add(tempProduct5);
            Products.Add(tempProduct6);

            Part tempPart1 = new InHouse(1, "Skate Wheel", 100.00m, 10, 200, 50, 101);
            Part tempPart2 = new InHouse(2, "Board", 300.00m, 20, 300, 50, 102);
            Part tempPart3 = new InHouse(3, "Seat", 200.00m, 30, 400, 50, 103);
            Part tempPart4 = new Outsourced(4, "Tire", 400.00m, 40, 500, 60, "Some Company");
            Part tempPart5 = new Outsourced(5, "Frame", 700.00m, 45, 10, 10, "Some Company");
            Part tempPart6 = new Outsourced(6, "Greese", 200.00m, 60, 150, 60, "Some Company");

            AllParts.Add(tempPart1);
            AllParts.Add(tempPart2);
            AllParts.Add(tempPart3);
            AllParts.Add(tempPart4);
            AllParts.Add(tempPart5);
            AllParts.Add(tempPart6);

            tempProduct1.AssociatedParts.Add(tempPart1);
            tempProduct2.AssociatedParts.Add(tempPart2);
            tempProduct3.AssociatedParts.Add(tempPart3);
            tempProduct4.AssociatedParts.Add(tempPart4);
            tempProduct5.AssociatedParts.Add(tempPart5);
            tempProduct6.AssociatedParts.Add(tempPart6);

        }

        //Add Product
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //Remove Product
        public bool RemoveProduct(int productID)
        {
            bool finished = false;

            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return finished = true;
                }
                else
                {
                    MessageBox.Show("Cannot Remove Product");
                }
            }
            return finished;
        }

        //Lookup Part
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            Product emptyProduct = new Allen_Miller_Inventory_Management_System.Product();
            return emptyProduct;
        }

        //UpdateProduct
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product selectedProduct in Products)
            {
                if (selectedProduct.ProductID == productID)
                {
                    selectedProduct.Name = updatedProduct.Name;
                    selectedProduct.InStock = updatedProduct.InStock;
                    selectedProduct.Price = updatedProduct.Price;
                    selectedProduct.Max = updatedProduct.Max;
                    selectedProduct.Min = updatedProduct.Min;
                    selectedProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        //Add Part
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //Delete Part
        public bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Lookup Part
        public static Part LookupPart(int? partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part noPart = null;
            return noPart;
        }

        //Update Part
        public static void InHouseModify(int partID, InHouse updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(Allen_Miller_Inventory_Management_System.InHouse))
                {
                    InHouse newInHouse = (InHouse)AllParts[i];
                    if (newInHouse.PartID == partID)
                    {
                        newInHouse.Name = updatedPart.Name;
                        newInHouse.InStock = updatedPart.InStock;
                        newInHouse.Price = updatedPart.Price;
                        newInHouse.Max = updatedPart.Max;
                        newInHouse.Min = updatedPart.Min;
                        newInHouse.MachineID = updatedPart.MachineID;
                    }
                }
            }
        }

        public static void OutsourcedModify(int partID, Outsourced updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(Allen_Miller_Inventory_Management_System.Outsourced))
                {
                    Outsourced newOutsourced = (Outsourced)AllParts[i];
                    if (newOutsourced.PartID == partID)
                    {
                        newOutsourced.Name = updatedPart.Name;
                        newOutsourced.InStock = updatedPart.InStock;
                        newOutsourced.Price = updatedPart.Price;
                        newOutsourced.Max = updatedPart.Max;
                        newOutsourced.Min = updatedPart.Min;
                        newOutsourced.CompanyName = updatedPart.CompanyName;
                    }
                }
            }
        }
    }
}
