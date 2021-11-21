using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLoggerLib;

namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLogger.CurrentLogger.Log("Main is getting called...");

            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1: SQL, 2: ORACAL");

            int choice = Convert.ToInt32(Console.ReadLine());

            getObject of = new getObject();
            database db = of.getObjectInstance(choice);

            Console.WriteLine("Enter functionality choice:");
            Console.WriteLine("1: insert, 2: update , 3. delete");

            int severChoice = Convert.ToInt32(Console.ReadLine());

            switch (severChoice)
            {
                case 1:
                    db.insert();
                    break;
                case 2:
                    db.update();
                    break;
                case 3:
                    db.delete();
                    break;
                default:
                    break;
            }

            Console.ReadLine();

        }
    }



    class getObject
    {
        public database getObjectInstance(int choice)
        {
            if (choice == 1)
            {
                return new SQL();
            }
            else
            {
                return new ORACAL();
            }
        }
    }

    abstract class database
    {
        public abstract void insert();

        public abstract void update();

        public abstract void delete();
    }

    class SQL : database
    {
        public override void delete()
        {
            Console.WriteLine("SQL DELETE Function");
            MyLogger.CurrentLogger.Log("SQL DELETE Function");
        }

        public override void insert()
        {
            Console.WriteLine("SQL INSERT Function");
            MyLogger.CurrentLogger.Log("SQL INSERT Function");
        }

        public override void update()
        {
            Console.WriteLine("SQL UPDATE Function");
            MyLogger.CurrentLogger.Log("SQL UPDATE Function");
        }
    }

    class ORACAL : database
    {
        public override void delete()
        {
            Console.WriteLine("ORACAL DELETE Function");
            MyLogger.CurrentLogger.Log("ORACAL DELETE Function");
        }

        public override void insert()
        {
            Console.WriteLine("ORACAL INSERT Function");
            MyLogger.CurrentLogger.Log("ORACAL INSERT Function");
        }

        public override void update()
        {
            Console.WriteLine("ORACAL UPDATE Function");
            MyLogger.CurrentLogger.Log("ORACAL UPDATE Function");
        }
    }
}

