using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1:PDF, 2: Word, 3: Excel");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1 :
                    PDF();
                    
                    break;
                case 2:

                    WORD();
                    break;
                case 3:
                    EXCEL();
                    
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    
                    break;
            }
            Console.ReadLine();
        }
        public static void PDF()
        {
            //pdf
            Console.WriteLine("PDF parsing is Done");
            Console.WriteLine("PDF Validation is Done");
            Console.WriteLine("PDF Saving is Done");

        }
        public static void WORD()
        {
            //word
            Console.WriteLine("WORD parsing is Done");
            Console.WriteLine("WORD Validation is Done");
            Console.WriteLine("WORD Saving is Done");
        }
        public static void EXCEL()
        {
            //Excel
            Console.WriteLine("EXCEL parsing is Done");
            Console.WriteLine("EXCEL Validation is Done");
            Console.WriteLine("EXCEL Saving is Done");
        }
        }
}
