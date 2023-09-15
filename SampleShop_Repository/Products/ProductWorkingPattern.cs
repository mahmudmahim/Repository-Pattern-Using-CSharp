using SampleShop_Repository.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository.Products
{
    public class ProductWorkingPattern
    {
        public static void ProductWorkingMethod(int index)
        {
            ProductRepo productRepo = new ProductRepo();

            //Getting All List Of Products
            if (index == 1)
            {
                var proRepo = productRepo.ShowAll();
                if (proRepo.Count() == 0)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("Sorry!! Products Not Found in The List...!!");
                    Console.WriteLine("****************************");
                    DisplayingOptionMethods.CommonDisplayOption2();
                }
                else
                {
                    foreach (var item in proRepo)
                    {
                        Console.WriteLine($"Product ID: {item.ProductId}, Product Name: {item.ProductName}, Price: {item.Price}");
                    }
                    Console.WriteLine();
                    DisplayingOptionMethods.CommonDisplayOption2();
                }
            }

            //Inserting Product List
            else if (index == 2)
            {
                Console.WriteLine("*****************************");
                Console.Write("Enter Product Name: \t");
                string pName = Console.ReadLine();
                Console.Write("Enter Product Price: \t");
                decimal pPrice = decimal.Parse(Console.ReadLine());

                int maxId = productRepo.ShowAll().Any() ? productRepo.ShowAll().Max(x => x.ProductId) : 0;
                ProductsInfo _productsInfo = new ProductsInfo()
                {
                    ProductId = maxId + 1,
                    ProductName = pName,
                    Price = pPrice
                };
                productRepo.Insert(_productsInfo);
                Console.WriteLine();
                Console.WriteLine("Data Inserted Successfully");
                Console.WriteLine();
                DisplayingOptionMethods.CommonDisplayOption2();
            }
            //Updating Products Info
            else if (index == 3)
            {
                Console.WriteLine("****************************");
                Console.Write("Enter Product ID You Want To Update: \t");
                int updateId = int.Parse(Console.ReadLine());
                var pId = productRepo.GetById(updateId);
                if (pId == null)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Sorry!! Product ID is Invalid!!");
                    Console.WriteLine("*********************************");
                    DisplayingOptionMethods.CommonDisplayOption2();

                }
                else
                {
                    Console.WriteLine($"Updating Product ID: \t{updateId}");
                    Console.WriteLine("*****************************");
                    Console.Write("Enter Product Name: \t");
                    string pName = Console.ReadLine();
                    Console.Write("Enter Product Price: \t");
                    decimal pPrice = decimal.Parse(Console.ReadLine());
                    ProductsInfo _productInfo = new ProductsInfo()
                    {
                        ProductId = updateId,
                        ProductName = pName,
                        Price = pPrice
                    };
                    productRepo.Update(_productInfo);
                    Console.WriteLine();
                    Console.WriteLine("Data Updated Successfully!!");
                    Console.WriteLine();
                    DisplayingOptionMethods.CommonDisplayOption2();
                }
            }
            //Deleting Products Info
            else if (index == 4)
            {
                Console.WriteLine("****************************");
                Console.Write("Enter Product ID You Want To Delete: \t");
                int deleteId = int.Parse(Console.ReadLine());
                var pId = productRepo.GetById(deleteId);
                if (pId == null)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Sorry!! Product ID is Invalid!!");
                    Console.WriteLine("*********************************");
                    DisplayingOptionMethods.CommonDisplayOption2();
                }
                else
                {
                    productRepo.Delete(deleteId);
                    Console.WriteLine();
                    Console.WriteLine("Deletion Successfully DOne.......!!");
                    Console.WriteLine();
                    DisplayingOptionMethods.CommonDisplayOption2();
                }
            }
            else if (index == 5)
            {
                DisplayingOptionMethods.DisplayOption();
            }
            else
            {
                Console.WriteLine("Invalid Input Given Please Try Again");
                DisplayingOptionMethods.DisplayOption();
            }
        }
    }
}
