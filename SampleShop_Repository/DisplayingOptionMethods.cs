using SampleShop_Repository.Products;
using SampleShop_Repository.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository
{
    public class DisplayingOptionMethods
    {
        
        public static void DisplayOption()
        {
            try
            {
                Console.Write("Please Select With Which You Want To Work: \t");
                Console.WriteLine("\n");
                Console.WriteLine("1. Suppliers \t2.Products \t3. Exit");
                int _index = int.Parse(Console.ReadLine());
                DesignPatternDisplay(_index);
            }
            catch (Exception ex)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Sorry!! Invalid Input Given. {ex.Message} ");
                Console.WriteLine("*********************************");
                DisplayOption();
            }
            //finally
            //{
            //    DisplayOption();
            //}

        }

        public static void DesignPatternDisplay(int _index)
        {
            if (_index == 1)
            {
                string InfoShow = "*********Currently Working With Supplier Information*********";
                Console.SetCursorPosition((Console.WindowWidth - InfoShow.Length) / 2, Console.CursorTop);
                Console.WriteLine(InfoShow);
                Console.WriteLine();
                CommonDisplayOption();
            }
            else if( _index == 2)
            {
                string InfoShow = "*********Currently Working With Products Information*********";
                Console.SetCursorPosition((Console.WindowWidth - InfoShow.Length) / 2, Console.CursorTop);
                Console.WriteLine(InfoShow);
                Console.WriteLine();
                CommonDisplayOption2();
            }
            else if(_index == 3)
            {
                Console.WriteLine("Thank You. Have a Good Day.");
                
            }
            else
            {
                Console.WriteLine("Invalid Input Given. Please Try Again");
                DisplayOption();
            }
        }

        public static void CommonDisplayOption()
        {
            try
            {
                Console.WriteLine("1. Show All Supplier List");
                Console.WriteLine("2. Insert Supplier");
                Console.WriteLine("3. Update Supplier");
                Console.WriteLine("4. Delete Supplier");
                Console.WriteLine("5. Exit/Back");
                int index = int.Parse(Console.ReadLine());
                SupplierWorkingMethods.SupplierWorkingPattern(index);
            }
            catch(Exception ex)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Sorry!! Invalid Input Given. {ex.Message} ");
                Console.WriteLine("*********************************");
                CommonDisplayOption();
            }
         
          
        }
        public static void CommonDisplayOption2()
        {
            try
            {
                Console.WriteLine("1. Show All Products");
                Console.WriteLine("2. Insert Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit/Back");
                int pIndex = int.Parse(Console.ReadLine());
                ProductWorkingPattern.ProductWorkingMethod(pIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Sorry!! Invalid Input Given. {ex.Message} ");
                Console.WriteLine("*********************************");
                CommonDisplayOption2();
            }
          
        }

    }
}
