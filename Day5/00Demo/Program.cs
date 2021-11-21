using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(23,"Pratiksha");
            #region             Below is the way to write Getter Setter like C++
            



            // person.Set_Name(" Pratiksha");
            // person.Set_Age(23);

            //   string nm = person.Get_Name();
            //  Console.WriteLine(nm);

            //  int age = person.Get_Age();
            //  Console.WriteLine(age);
            //Console.WriteLine(person.GetDetails());
            //Console.ReadLine();
            #endregion
        }
    }
    public class Person
    {
        #region Private Members
        private string _Name;//coding std from microsoft
        private int _Age;
        #endregion

        #region Constructors
        public Person()
        {
            this._Name = "";
            this._Age = 0;
        }

        public Person(int age, string name)
        {
            this.Set_Age(age);
            this.Set_Name(name);
        }

        /// <summary>
        /// This function helps you set up Name of the person
        /// You can try setting the name using personObject.Set_Name("john")
        /// </summary>
        /// <param name="name">This is name of the person</param>


        #endregion

        #region  Getter Setters
        public void Set_Name(string name)
        {
            if (name != "") //Validation
            {
                this._Name = name;
            }
            else
            {
                this._Name = "No Data";
            }

        }
        public string Get_Name()
        {
            return " Mr/Mrs " + this._Name;
        }
        public void Set_Age(int age)
        {
            this._Age = age;
        }
        public int Get_Age()
        {
            return this._Age;
        }

        #endregion

        #region Member Functions
        public string GetDetails()
        {
            return "Welcome " + this.Get_Name() + "with Age " +
                this.Get_Age().ToString();
        }
        #endregion

    }

    
}
