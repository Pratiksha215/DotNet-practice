using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Person
    {
        #region data Members
        private string _name;
        private string _gender;
        private Date _birth;
        private string _address;
        private string _emailId;

     

        #endregion

        #region Constructor
        public Person()
        {
            _name = "dhiraj";
            _gender = "male";
            _birth = new Date();
            _address = "jalgaon";
            _emailId = "abc@gmail.com";

        }

        public Person(string name, string gender, Date birth, string address , string emailid)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
            EmailId = emailid;
        }
        #endregion


        #region Getter and Setter

        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public Date Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }


        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return "Person Name is " + Name + " , "
                    + " Gender is " + Gender
                    + " having BirthDate is " + Birth
                    + " from " + Address
                    + " Email Id : " + EmailId;

        }

        public void getDetails()
        {
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter Gender");
            Gender = Console.ReadLine();
            Console.WriteLine("enter Birth date");
            this.Birth.acceptDetails();
            Console.WriteLine("enter Address");
            Address = Console.ReadLine();
            Console.WriteLine("enter Email Id");
            EmailId = Console.ReadLine();
        }

        public void printDetails()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion



    }




}
