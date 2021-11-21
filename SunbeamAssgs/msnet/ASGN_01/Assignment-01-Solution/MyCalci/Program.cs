using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicNS;
using TempratureNS;

namespace MyCalci
{
    class Program
    {
        static void Main(string[] args)
        {

            string select = "y";

            do
            {
                Console.WriteLine("Enter main Your Choice");
                Console.WriteLine("1: Basic Calculator, 2: Tempreture conversion");
                int mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        {
                            string isContinue = "y";

                            do
                            {
                                Console.WriteLine("Enter Your Choice");
                                Console.WriteLine("1: Add, 2: Sub, 3: Mult, 4: Div");
                                int choice = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Value for X");
                                int x = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Value for Y");
                                int y = Convert.ToInt32(Console.ReadLine());
                                int result = 0;

                                BasicCalculator obj = new BasicCalculator();

                                switch (choice)
                                {
                                    case 1:
                                        result = obj.add(x, y);
                                        break;
                                    case 2:
                                        result = obj.sub(x, y);
                                        break;
                                    case 3:
                                        result = obj.mul(x, y);
                                        break;
                                    case 4:
                                        result = obj.div(x, y);
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Choice..Try Again!");
                                        break;
                                }

                                Console.WriteLine(result);
                                Console.WriteLine("Do you want to contine y/n");

                                isContinue = Console.ReadLine();


                            } while (isContinue == "y");

                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        {
                            string isContinue = "y";

                            do
                            {
                                Console.WriteLine("Enter Your Choice");
                                Console.WriteLine("1: FarenheitToCelcius, 2: CelciusToFarenheit) ");
                                int choice = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Value for conversion");
                                double x = Convert.ToDouble(Console.ReadLine());

                                double result = 0;

                                TempratureConverter obj1 = new TempratureConverter();

                                switch (choice)
                                {
                                    case 1:
                                        result = obj1.FarenheitToCelcius(x);
                                        break;
                                    case 2:
                                        result = obj1.CelciusToFarenheit(x);
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Choice..Try Again!");
                                        break;
                                }

                                Console.WriteLine(result);
                                Console.WriteLine("Do you want to contine y/n");

                                isContinue = Console.ReadLine();


                            } while (isContinue == "y");

                            Console.ReadLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice..Try Again!");
                        break;


                }

                Console.WriteLine("Do you want to exit y/n");

                select = Console.ReadLine();

            } while (select == "n");

            

        }
    }
}
