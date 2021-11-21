using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace assgn_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Manual testing
            //Department d1 = new Department(50, "Trainig", "Karad");

            //Console.WriteLine(d1.ToString());

            //Employee e1 = new Employee(10, "dhiraj", "dfghj", 111.11, 33.33, 50);

            //Console.WriteLine(e1.ToString()); 
            #endregion

            #region Read Department input from dept.csv

            string deptstring = "";
            //  List<Department> deptList = new List<Department>();
            Dictionary<int, Department> DeptList = new Dictionary<int, Department>();  

            FileStream fs = new FileStream(@"F:\Dhiraj C-DAC\Classwork_data_online\msnet\assignments\dept.csv",
                                            FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);

            // Open file and Read line by line
            while ((deptstring = reader.ReadLine()) != null)
            {
                //line fetched from csv file
                // Split details separated by a comma followed by space

                string[] deptDetails = deptstring.Split(',');
                Department dept = new Department();
                dept.DeptNo = int.Parse(deptDetails[0]);
                dept.DeptName = deptDetails[1];
                dept.Location = deptDetails[2];

                DeptList.Add(dept.DeptNo, dept);

                //  Console.WriteLine(dept.ToString());

            }

            //foreach (int key in DeptList.Keys)
            //{
            //    Department d = DeptList[key];

            //    Console.WriteLine(d.ToString());
            //}
            #endregion


            #region Read Employee input from emp.csv

            string empstring = "";
            //List<Employee> empList = new List<Employee>();
            Dictionary<int, Employee> EmpList = new Dictionary<int, Employee>();

            FileStream empfs = new FileStream(@"F:\Dhiraj C-DAC\Classwork_data_online\msnet\assignments\emp.csv",
                                            FileMode.Open, FileAccess.Read);

            StreamReader empreader = new StreamReader(empfs);

            // Open file and Read line by line
            while ((empstring = empreader.ReadLine()) != null)
            {
                //line fetched from csv file
                // Split details separated by a comma followed by space

                string[] empDetails = empstring.Split(',');

                Employee emp = new Employee();

                emp.EmpNo = int.Parse(empDetails[0]);
                emp.Name = empDetails[1];
                emp.Designation = empDetails[2];
                emp.Salary = double.Parse(empDetails[3]);
                emp.Commission = double.Parse(empDetails[4]);
                emp.Dno = int.Parse(empDetails[5]);
                

                EmpList.Add(emp.EmpNo , emp);

                //  Console.WriteLine(dept.ToString());

            }

            //foreach (int empkey in EmpList.Keys)
            //{
            //    Employee e = EmpList[empkey];

            //    Console.WriteLine(e.ToString());
            //}
            #endregion

            #region Get Location
            //List<string> str = LocationWithSingleDept(DeptList);

            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get Department Having no employees

            List<string> departmentNames = FindDeptsWithNoEmps(EmpList, DeptList);

            Console.WriteLine("Department wirh no Employee  :: ");

            foreach (string deptName in departmentNames)
            {
                Console.WriteLine(deptName);
            }

            #endregion

            #region Total salary of employee
            //Dictionary<int, double> DepartmentwiseTotalSalary = Calcluate_Total_Salary(EmpList);

            //foreach (int key in DepartmentwiseTotalSalary.Keys)
            //{
            //    Console.WriteLine("department number = " + key + "    " +
            //                        "Total Salary = " + DepartmentwiseTotalSalary[key]);
            //}
            #endregion

            #region Get Employee by Department id

            //List<Employee> Emp = GetAllEmployeesByDept(10, EmpList);

            //if (Emp.Count == 0)
            //{
            //    Console.WriteLine("this Department Doesn't have Employee");
            //}
            //else
            //{
            //    foreach (Employee employee in Emp)
            //    {
            //        Console.WriteLine(employee.ToString());
            //    }
            //}


            #endregion

            #region Get departmentwise employee count
            Dictionary<int, double> DepartmentwiseEmpCount = DeptwiseStaffCount(EmpList);

            foreach (int key in DepartmentwiseEmpCount.Keys)
            {
                Console.WriteLine("department number = " + key + "    " +
                                    "Total Staff count = " + DepartmentwiseEmpCount[key]);
            }
            #endregion

            #region Get departmentwise Average Salary
            //Dictionary<int, double> DepartmentwiseAvgSalary = DeptwiseAvgSal(EmpList);

            //foreach (int key in DepartmentwiseAvgSalary.Keys)
            //{
            //    Console.WriteLine("department number = " + key + "    " +
            //                        "Average Salary = " + DepartmentwiseAvgSalary[key]);
            //}
            #endregion

            #region Get department wise minimum salary
            //Dictionary<int, double> DepartmentwiseMinSalary = DeptwiseMinSal(EmpList);

            //foreach (int key in DepartmentwiseMinSalary.Keys)
            //{
            //    Console.WriteLine("department number = " + key + "    " +
            //                        "Minimun Salary = " + DepartmentwiseMinSalary[key]);
            //}
            #endregion

            #region Get Employee information

            //Dictionary<string , string> allEmployee = GetEmpInfo(EmpList , DeptList);

            //foreach (string key in allEmployee.Keys)
            //{
            //    Console.WriteLine("department Name = " + allEmployee[key]  + "    " +
            //                        "Employee Name = " + key );
            //}
            #endregion



            Console.ReadLine();

        }

        static List<string> LocationWithSingleDept(Dictionary<int, Department> deptList)
        {
            List<string> location = new List<string>();

            #region Using For-each loop
            /*
            List<Department> dept = new List<Department>();

            foreach (int outer_key in deptList.Keys)
            {
                dept.Add(deptList[outer_key]);
            }

            location = dept.GroupBy(d => d.Location).Where(g => g.Count() > 1).Select(g => g.Key).ToList();


            foreach (Department d1 in dept)
            {
                int count = 0;

                foreach (Department d2 in dept)
                {
                    if (d1.Location == d2.Location)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    location.Add(d1.Location);
                }
                else
                {
                    location.Add(" ");
                }
            } 
            */
            #endregion


            #region Using LinQ
            var result = from dept in deptList.Values
                         group dept by dept.Location;


            foreach (var res in result)
            {
                //  Console.WriteLine(res.Key);

                 // Console.WriteLine(res.Key + "  " + res.Count());

                if (res.Count() == 1)
                {
                    location.Add(res.Key);
                }
            } 
            #endregion

            return location;
        }

        static List<string> FindDeptsWithNoEmps(Dictionary<int, Employee> empList , Dictionary<int, Department> deptList)
        {
            List<string> deptNames = new List<string>();
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            //foreach (var item in empList.Keys)
            //{
            //    employees.Add(empList[item]);
            //}

            //foreach (var item in deptList.Keys)
            //{
            //    departments.Add(deptList[item]);
            //}

            #region Using ForEach loop
            /*
            foreach (int deptKey in deptList.Keys)
            {
                bool Found = false;
                Department d = deptList[deptKey];

                foreach (int empKey in empList.Keys)
                {
                    Employee e = empList[empKey];

                    if (d.DeptNo == e.Dno)
                    {
                        Found = true;
                        break;
                    }

                }

                if (Found == false)
                {
                    deptNames.Add(d.DeptName);
                }
            } 
            */
            #endregion

            #region Using LinQ

            //var result = (from d in departments
            //              join e in employees on
            //              d.DeptNo equals e.Dno into demo
            //              from temp in demo.DefaultIfEmpty()
            //              select new
            //              {
            //                  DeptName = d.DeptName,
            //                  count = temp == null
            //              }).ToList();


            // Better Aprroach
            var result = (from d in deptList.Values
                          join e in empList.Values on
                          d.DeptNo equals e.Dno into demo
                          from temp in demo.DefaultIfEmpty()
                          select new
                          {
                              DeptName = d.DeptName,
                              count = temp == null
                          }).ToList();

            foreach (var res 
                in result)
            {
                Console.WriteLine(res);
               if(res.count == true)
                {
                    deptNames.Add(res.DeptName);
                }
            }



            #endregion

            return deptNames;
        }

        static Dictionary<int, double> Calcluate_Total_Salary(Dictionary<int, Employee> empList)
        {
            #region using ForEach
           // double totalSalary = 0.0;

            //foreach (int key in empList.Keys)
            //{
            //    Employee e = empList[key];

            //    totalSalary = totalSalary + e.Salary + e.Commission;
            //}
           // return totalSalary;
            #endregion

            var result = (from e in empList.Values
                          orderby e.Dno ascending
                          group e by e.Dno into emp
                          where emp.Count() > 1 
                          select new
                          {
                              DeptNo = emp.Key,
                              TotalSalary = emp.Sum(x => x.Salary) + emp.Sum(x => x.Commission)
                          }).ToDictionary(x => x.DeptNo, x => x.TotalSalary);

            
            
            return result;




        }

        static List<Employee> GetAllEmployeesByDept(int DeptNo , Dictionary<int, Employee> empList)
        {
            List<Employee> emp = new List<Employee>();

            #region Using forEach 
            //foreach (int key in empList.Keys)
            //{
            //    Employee e = empList[key];

            //    if(DeptNo == e.Dno)
            //    {
            //        emp.Add(e);
            //    }
            //} 
            #endregion


            #region Using LINQ
            var result = from e in empList.Values
                         where e.Dno == DeptNo
                         select e;

            foreach (var res in result)
            {
                emp.Add(res);
            } 
            #endregion



            return emp;
        }

        static Dictionary<int, double> DeptwiseStaffCount(Dictionary<int, Employee> empList)
        {
            #region Using ForEach

            //Dictionary<int, double> DepartmentwiseEmpCount = new Dictionary<int, double>();
            //List<int> departments = new List<int>();

            //foreach (int key in empList.Keys)
            //{
            //    Employee e = empList[key];
            //    departments.Add(e.Dno);
            //}

            //departments = departments.Distinct().ToList();
            //departments.Sort();

            
            //foreach (int deptno in departments)
            //{
            //    double count = 0.0;
            //    foreach (int key in empList.Keys)
            //    {
            //        Employee e = empList[key];
            //        if(deptno == e.Dno )
            //        {
            //            count++;
            //        }
            //    }

            //    DepartmentwiseEmpCount.Add(deptno, count);
            //} 

            //return DepartmentwiseEmpCount;

            #endregion

            #region Using LINQ

            var result = (from e in empList.Values
                          orderby e.Dno ascending
                          group e by e.Dno into emp
                          where emp.Count() > 1
                          select new
                          {
                              DeptNo = emp.Key,
                              StaffCount = (double)emp.Count()
                          }).ToDictionary(x => x.DeptNo, x => x.StaffCount);

            return result;
            #endregion
            
        }

        static Dictionary<int, double> DeptwiseAvgSal(Dictionary<int, Employee> empList)
        {
            #region using Foreach
            //Dictionary<int, double> DepartmentwiseAvgSalary = new Dictionary<int, double>();
            //List<int> departments = new List<int>();

            //foreach (int key in empList.Keys)
            //{
            //    Employee e = empList[key];
            //    departments.Add(e.Dno);
            //}

            //departments = departments.Distinct().ToList();
            //departments.Sort();

            
            //foreach (int deptno in departments)
            //{
            //    double count = 0;
            //    double total = 0;

            //    foreach (int key in empList.Keys)
            //    {
            //        Employee e = empList[key];
            //        if (deptno == e.Dno)
            //        {
            //            count++;
            //            total = total + e.Salary + e.Commission;
            //        }
            //    }

            //    DepartmentwiseAvgSalary.Add(deptno, (total / count));
            //} 
           // return DepartmentwiseAvgSalary;

            #endregion

            #region Using LINQ
            var result = (from e in empList.Values
                          orderby e.Dno ascending
                          group e by e.Dno into emp
                          where emp.Count() > 1
                          select new
                          {
                              DeptNo = emp.Key,
                              AvgSalary = emp.Average(x => (x.Salary + x.Commission))
                          }).ToDictionary(x => x.DeptNo, x => x.AvgSalary);

            return result;
            #endregion
            
        }

        static Dictionary<int, double> DeptwiseMinSal(Dictionary<int, Employee> empList)
        {
            #region Using foreach
            /*
            Dictionary<int, double> DepartmentwiseMinSalary = new Dictionary<int, double>();
            List<int> departments = new List<int>();

            foreach (int key in empList.Keys)
            {
                Employee e = empList[key];
                departments.Add(e.Dno);
            }

            departments = departments.Distinct().ToList();
            departments.Sort();

            
                foreach (int deptno in departments)
                {
                    double minimum = Double.MaxValue;

                    foreach (int key in empList.Keys)
                    {
                        Employee e = empList[key];
                        if (deptno == e.Dno)
                        {
                            if(e.Salary < minimum )
                            {
                                minimum = e.Salary;
                            }
                        }
                    }

                    DepartmentwiseMinSalary.Add(deptno, minimum);
                }

                return DepartmentwiseMinSalary;
                */
            #endregion

            #region Using LINQ

            var result = (from e in empList.Values
                          orderby e.Dno ascending
                          group e by e.Dno into emp
                          where emp.Count() > 1
                          select new
                          {
                              DeptNo = emp.Key,
                              MinSalary = emp.Min(x => x.Salary)
                          }).ToDictionary(x => x.DeptNo, x => x.MinSalary);

            return result;

            #endregion

            
        }

        static Dictionary<string, string> GetEmpInfo(Dictionary<int, Employee> EmpList, Dictionary<int, Department> DeptList)
        {
            Dictionary<string, string> employeeInfo = new Dictionary<string, string>();

            var result = from e in EmpList.Values
                         join d in DeptList.Values on
                         e.Dno equals d.DeptNo
                         select new
                         {
                             Ename = e.Name,
                             Dname = d.DeptName
                         };

            foreach (var res in result)
            {
                employeeInfo.Add(res.Ename , res.Dname);
            }

            return employeeInfo;
        }
   
    }
}
