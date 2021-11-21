using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class WageEmp : Employee
    {
        private int hours;
        private int rate;

        public WageEmp()
        {
            Hours = 0;
            Rate = 0;
        }

        public WageEmp(int hour, int rate)
        {
            Hours = hour;
            Rate = rate;
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }


        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " "
                    + " Hours  : " + Hours
                    + " Rate per hour : " + Rate
                    + "  net salary is : " + NetSalary;

        }

        public override double NetSalary
        {
            get
            {
                return Hours * Rate;
            }

        }

        public void acceptWageEmployeeDetails()
        {
            base.acceptDetails();
            Console.WriteLine("Enter rate");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours");
            Hours = Convert.ToInt32(Console.ReadLine());

        }

        public void PrintWageEmpDetails()
        {
            Console.WriteLine(this.ToString());
        }
    }

}