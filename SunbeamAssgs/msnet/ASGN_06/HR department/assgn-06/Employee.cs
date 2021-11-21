using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn_06
{
    [Serializable]
    public class Employee
    {

        #region Data Members
        private int _empNo;
        private string _name;
        private string _designation;
        private double _salary;
        private double _commission;
        private int _dno;

        #endregion


        #region Constructors
        public Employee()
        {
            Dno = 1;
            Commission = 0.0;
            Salary = 0.0;
            Designation = "test";
            Name = "abc";
            EmpNo = 1;
        }

        public Employee(int empNo, string name, string designation, double salary, double commission, int dno)
        {
            EmpNo = empNo;
            Name = name;
            Designation = designation;
            Salary = salary;
            Commission = commission;
            Dno = dno;
        }

        #endregion


        #region Properties
        public int Dno
        {
            get { return _dno; }
            set { _dno = value; }
        }


        public double Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }


        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }



        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int EmpNo
        {
            get { return _empNo; }
            set { _empNo = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Employee Number = {0} \r\n" +
                "Employee Name = {1} \r\n" +
                "Designation = {2} \r\n" +
                "Salary = {3} \r\n" +
                "Commission = {4} \r\n" +
                "Department number = {5} \r\n" +
                "******************************************************************** \r\n",
                this.EmpNo , this.Name , this.Designation , this.Salary , this.Commission , this.Dno);
        }
        #endregion


    }
}
