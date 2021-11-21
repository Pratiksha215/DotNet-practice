using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn_06
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
            Location = "xyz";
            DeptName = "pqr";
            DeptNo = 1;
        }

        public Department(int deptNo, string deptName, string location)
        {
            DeptNo = deptNo;
            DeptName = deptName;
            Location = location;
        }


        #endregion

        #region Properties
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
        public override string ToString()
        {
            return string.Format("Department number = {0} \r\n" +
                                    "Department Name = {1} \r\n" +
                                     "Location = {2} \r\n" +
                                     "**************************************************** \r\n",
                                     this.DeptNo , this.DeptName , this.Location);
        }
        #endregion


    }
}
