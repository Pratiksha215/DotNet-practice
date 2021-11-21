using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Department
    {
        #region Data Members
        private int _deptNo;
        private string _deptName;
        private string _location;
        #endregion

        #region Constructors

        public Department()
        {
            DeptNo = 0;
            DeptName = "abcd";
            Location = "xyz";
        }

        public Department(int deptno , string deptname , string location)
        {
            DeptNo = deptno;
            DeptName = deptname;
            Location = location;
        }

        #endregion

        #region Getter & Setter
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }


        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }


        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }
        #endregion

        #region Methods
        public void PrintDepartmentDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + " "
                    + " Department number : " + DeptNo
                    + "  Department name  : " + DeptName
                    + " ,  Location : " + Location;


        }

        public void acceptDepartmentDetails()
        {

            Console.WriteLine("enter Department number");
            DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Depatment Name");
            DeptName = Console.ReadLine();
            Console.WriteLine("enter Location");
            Location = Console.ReadLine();

        } 
        #endregion

    }
}
