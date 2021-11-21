using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Employee : Person
    {

        private int id;
        public static int _count = 100;
        private double _salary;
        private string _designation;
        private Employeetype _emptype;
        private string _passcode;
        private int _deptNo;
        private Date _hiredate;

       


        #region Constructors
        public Employee()
        {
            Salary = 0.0;
            Designation = "none";
            EmpType = Employeetype.trainee;
            Passcode = "abc";
            DeptNo = 0;
            HireDate = new Date();
            //  Hra = 0.0;
            //  Da = 0.0;
        }

        public Employee(double salary, string designation, Employeetype emptype , 
                        string passcode , int deptno , Date hireDate)
        {

            Salary = salary;
            Designation = designation;
            EmpType = emptype;
            Passcode = passcode;
            DeptNo = deptno;
            HireDate = hireDate;

        }
        #endregion

        #region Getter & setter and Properties

        public Date HireDate
        {
            get { return _hiredate; }
            set { _hiredate = value; }
        }


        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }


        public string Passcode
        {
            get { return _passcode; }
            set { _passcode = value; }
        }

        public double Da
        {
            get
            {

                return 0.1 * _salary;
            }

        }


        public double Hra
        {
            get
            {

                return 0.4 * _salary;
            }



        }
        public int Id
        {
            get 
            {
                _count++;
                id = _count;

                return id;
            }
           

        }

        public virtual double NetSalary
        {
            get
            {
                return Hra + Da + Salary;
            }

        }


        public Employeetype EmpType
        {
            get { return _emptype; }
            set { _emptype = value; }
        }



        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        public double Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;

            }
        } 
        #endregion

        public void PrintEmployeeDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + " "
                    + " employee Id : " + Id
                    + "  Designation : " + Designation
                    + " ,  employee is : " + EmpType
                    + " Passcode : " + Passcode
                    + " Department number : " + DeptNo
                    + " Hire date : " + HireDate.ToString();

                    
        }

        public void acceptDetails()
        {
            base.getDetails();
            Console.WriteLine("enter Passcode");
            Passcode = Console.ReadLine();
            Console.WriteLine("enter Depatment number");
            DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Hire date");
            this.HireDate.acceptDetails();
            Console.WriteLine("Select Employee type");
            Console.WriteLine("1. trainee");
            Console.WriteLine("2. permanent");
            Console.WriteLine("3. temporary");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EmpType = Employeetype.trainee;
                    break;
                case 2:
                    EmpType = Employeetype.permanent;
                    break;
                case 3:
                    EmpType = Employeetype.temporary;
                    break;
                default:
                    break;
            }
            
            Console.WriteLine("enter Designation");
            Designation = Console.ReadLine();
           
        }

    }

}
