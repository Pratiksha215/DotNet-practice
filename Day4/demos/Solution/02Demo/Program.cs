using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1:PDF, 2: Excel, 3: Word");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PDF obj = new PDF();
                    obj.Parse();
                    obj.Validate();
                    obj.Save();
                    break;
                case 2:
                    Excel obj1 = new Excel();
                    obj1.Parse();
                    obj1.Validate();
                    obj1.Save();

                    break;
                case 3:
                    Word obj2 = new Word();
                    obj2.Parse();
                    obj2.Validate();
                    obj2.Save();

                    break;
                default:
                    Console.WriteLine("Invalid Choice");

                    break;
            }
            Console.ReadLine();
        }
        

        public class PDF 
        {

            public void Parse()
            {
                Console.WriteLine("PDF parsing is Done");

            }
            public void Validate()
            {
                Console.WriteLine("PDF validation is Done");

            }
            public void Save()
            {
                Console.WriteLine("PDF saving is Done");

            }
        }
        public class Excel
        {

            public void Parse()
            {
                Console.WriteLine("Excel parsing is Done");

            }
            public void Validate()
            {
                Console.WriteLine("Excel validation is Done");

            }
            public void Save()
            {
                Console.WriteLine("Excel saving is Done");

            }
        }
        public class Word
        {

            public void Parse()
            {
                Console.WriteLine("Word parsing is Done");

            }
            public void Validate()
            {
                Console.WriteLine("Word validation is Done");

            }
            public void Save()
            {
                Console.WriteLine("Word saving is Done");

            }
        }
    }
}
