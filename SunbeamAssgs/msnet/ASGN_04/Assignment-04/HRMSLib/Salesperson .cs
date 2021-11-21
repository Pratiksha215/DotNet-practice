using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Salesperson : Employee
    {
        private double _commission;

        public double Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }

        public Salesperson()
        {
            Commission = 0.0;
        }

        public Salesperson(double commission)
        {
            Commission = commission;
        }

        public override double NetSalary
        {
            get
            {
                return Hra + Da + Salary + Commission;
            }

        }

        public override string ToString()
        {
            return base.ToString() + " "
                     + " salary : " + Salary
                     + "  net salary is : " + NetSalary
                     + " Commision  : " + Commission;
                    
        }

        public void acceptSalesPersonDetails()
        {
            base.acceptDetails();
            Console.WriteLine("enter salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Commision");
            Commission = Convert.ToDouble(Console.ReadLine());
           
        }

        public void PrintSalesPersonDetails()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
