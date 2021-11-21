using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSLib;

namespace assgn_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Menu - Driven
            string isRepeat = "y";
            int isContinue = 0;
           

            do
            {
                Console.WriteLine("Select your choice");
                Console.WriteLine("1 . SalesPerson    2 . Wage Employee    3 . Department");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        {
                            Salesperson sp = new Salesperson();

                            do
                            {
                                Console.WriteLine("Enter functionality choice:");
                                Console.WriteLine("1 . AcceptDetails    2 . PrintDetails");

                                int functionChoice = Convert.ToInt32(Console.ReadLine());

                                switch (functionChoice)
                                {
                                    case 1:
                                        sp.acceptSalesPersonDetails();
                                        break;
                                    case 2:
                                        sp.PrintSalesPersonDetails();
                                        break;
                                    default:
                                        break;
                                }

                                Console.WriteLine("do you want to continue..... 1. yes 2. no");
                                isContinue = Convert.ToInt32(Console.ReadLine());


                            } while (isContinue == 1);




                            break;

                        }

                    case 2:
                        {
                            WageEmp we = new WageEmp();

                            do
                            {
                                Console.WriteLine("Enter functionality choice:");
                                Console.WriteLine("1 . AcceptDetails    2 . PrintDetails");

                                int functionChoice = Convert.ToInt32(Console.ReadLine());

                                switch (functionChoice)
                                {
                                    case 1:
                                        we.acceptWageEmployeeDetails();
                                        break;
                                    case 2:
                                        we.PrintWageEmpDetails();
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine("do you want to continue..... 1. yes 2. no");
                                isContinue = Convert.ToInt32(Console.ReadLine());


                            } while (isContinue == 1);

                            break;
                        }

                    case 3:
                        {
                            Department d1 = new Department();

                            do
                            {
                                Console.WriteLine("Enter functionality choice:");
                                Console.WriteLine("1 . AcceptDetails    2 . PrintDetails");

                                int functionChoice = Convert.ToInt32(Console.ReadLine());

                                switch (functionChoice)
                                {
                                    case 1:
                                        d1.acceptDepartmentDetails();
                                        break;
                                    case 2:
                                        d1.PrintDepartmentDetails();
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine("do you want to continue..... 1. yes 2. no");
                                isContinue = Convert.ToInt32(Console.ReadLine());


                            } while (isContinue == 1);

                            break;
                        }



                    default:
                        break;

                }

                Console.WriteLine("do you want to exit..... y/n");
                isRepeat = Console.ReadLine();



            } while (isRepeat == "n");
            #endregion

            #region Date
            //Date d1 = new Date(01, 11, 2020);

            //Console.WriteLine(d1.ToString());

            //Date d2 = new Date(01, 11, 2028);

            //Console.WriteLine(d2.ToString());

            //Console.ReadLine();

            //Date d1 = new Date();
            //d1.acceptDetails();
            //d1.PrintDetails();

            //Date d2 = new Date();
            //d2.acceptDetails();
            //d2.PrintDetails();

            //Console.WriteLine("year Difference = " + Date.GetDifference(d2, d1));
            #endregion

            #region Person
            //Person p1 = new Person();

            //p1.getDetails();

            //p1.printDetails();

            //Console.WriteLine(Date.GetDifference(DateTime.Today, p1.Birth));


            #endregion

            #region Employee

            //Employee e1 = new Employee();

            //e1.acceptDetails();

            //e1.PrintEmployeeDetails();
            #endregion

            #region Salesperson
            //Salesperson sp1 = new Salesperson();

            //sp1.acceptSalesPersonDetails();

            //sp1.PrintSalesPersonDetails();
            #endregion

            #region Wage Employee
            //WageEmp we1 = new WageEmp();

            //we1.acceptWageEmployeeDetails();

            //we1.PrintWageEmpDetails();


            #endregion

            #region Department

            //Department d1 = new Department();

            //d1.acceptDepartmentDetails();

            //d1.PrintDepartmentDetails();

            #endregion

            Console.ReadLine();
        }
    }



   

}
