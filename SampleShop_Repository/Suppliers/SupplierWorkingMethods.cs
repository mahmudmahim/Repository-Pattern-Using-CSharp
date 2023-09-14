using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository.Suppliers
{
    public class SupplierWorkingMethods
    {
        public static void SupplierWorkingPattern(int index)
        {
            SupplierRepo supplierRepo = new SupplierRepo();

            //Getting All List Of Suppliers
            if (index == 1)
            {
                var suppRepo = supplierRepo.ShowAll();
                if (suppRepo.Count() == 0)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("Sorry!! Supplier Not Found in The List...!!");
                    Console.WriteLine("****************************");
                    DisplayingOptionMethods.CommonDisplayOption();
                }
                else
                {
                    foreach (var item in suppRepo)
                    {
                        Console.WriteLine($"Supplier ID: {item.SupplierId}, Company Name: {item.CompanyName}, Contact: {item.Contact}");
                    }
                    Console.WriteLine();
                    DisplayingOptionMethods.CommonDisplayOption();
                }
            }

            //Inserting Supplier List
            else if (index == 2)
            {
                Console.WriteLine("*****************************");
                Console.Write("Enter Company Name: \t");
                string cName = Console.ReadLine();
                Console.Write("Enter Contact Number: \t");
                string cNum = Console.ReadLine();

                int maxId = supplierRepo.ShowAll().Any() ? supplierRepo.ShowAll().Max(x => x.SupplierId) : 0;
                SupplierInfo _supplierInfo = new SupplierInfo()
                {
                    SupplierId = maxId + 1,
                    CompanyName = cName,
                    Contact = cNum
                };
                supplierRepo.Insert(_supplierInfo);
                Console.WriteLine("Data Inserted Successfully");
                DisplayingOptionMethods.CommonDisplayOption();
            }
            //Updating Supplier Info
            else if (index == 3)
            {
                Console.WriteLine("****************************");
                Console.Write("Enter Supplier ID You Want To Update: \t");
                int updateId = int.Parse(Console.ReadLine());
                var suppId = supplierRepo.GetById(updateId);
                if (suppId == null)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Sorry!! Supplier ID is Invalid!!");
                    Console.WriteLine("*********************************");
                    DisplayingOptionMethods.CommonDisplayOption();

                }
                else
                {
                    Console.WriteLine($"Updating Supplier ID: \t{updateId}");
                    Console.WriteLine("*****************************");
                    Console.Write("Enter Company Name: \t");
                    string cName = Console.ReadLine();
                    Console.Write("Enter Contact Number: \t");
                    string cNum = Console.ReadLine();
                    SupplierInfo _suppInfo = new SupplierInfo()
                    {
                        SupplierId = updateId,
                        CompanyName = cName,
                        Contact = cNum
                    };
                    supplierRepo.Update(_suppInfo);
                    Console.WriteLine("Data Updated Successfully!!");
                    DisplayingOptionMethods.CommonDisplayOption();
                }
            }
            //Deleting Supplier Info
            else if (index == 4)
            {
                Console.WriteLine("****************************");
                Console.Write("Enter Supplier ID You Want To Delete: \t");
                int deleteId = int.Parse(Console.ReadLine());
                var suppId = supplierRepo.GetById(deleteId);
                if (suppId == null)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Sorry!! Supplier ID is Invalid!!");
                    Console.WriteLine("*********************************");
                    DisplayingOptionMethods.CommonDisplayOption();
                }
                else
                {
                    supplierRepo.Delete(deleteId);
                    Console.WriteLine("Deletion Successfully DOne.......!!");
                    DisplayingOptionMethods.CommonDisplayOption();
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
