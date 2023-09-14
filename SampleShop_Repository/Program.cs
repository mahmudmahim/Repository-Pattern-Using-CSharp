using SampleShop_Repository.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InfoShow = "*********Welcome To SampleShop Information Desk*********";
            Console.SetCursorPosition((Console.WindowWidth - InfoShow.Length) / 2, Console.CursorTop);
            Console.WriteLine(InfoShow);
            Console.WriteLine();
            DisplayingOptionMethods.DisplayOption();  
            Console.ReadKey();
        }
    }
}
