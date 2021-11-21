using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Date
    {
       
        #region Data Members
        private  int _Day;
        private  int _Month;
        private  int _Year;
        #endregion

        #region constructor

        public Date()
        {
            _Year = 2000;
            _Month = 1;
            _Day = 1;
        }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;           
        }
        #endregion

        #region Getter and Setter
        public int Year
        {
            get { return _Year; }
            set 
            { 
                if(value >= 2000)
                {
                    _Year = value;
                }
                else
                {
                    Console.WriteLine("year is Invalid defaulting to 2000");
                    _Year = 2000;
                }
                
            }
        }


        public int Month
        {
            get { return _Month; }
            set 
            { 
                if(value > 0 && value <= 12)
                {
                    _Month = value;
                }
                else
                {
                    Console.WriteLine("Month is Invalid defaulting to 1");
                    _Month = 1;
                }

            }
        }


        public int Day
        {
            get { return _Day; }
            set 
            {
                int[] daysPerMonth = {0 , 31 , 28 , 31 , 30 , 31 , 30 , 31 , 31 , 30 , 31 , 30 , 31 };

                if(value > 0 && value <= daysPerMonth[Month])
                {
                    _Day = value;
                }
                else if (Month == 2 && value == 29 && 
                            (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0) ))
                {
                    _Day = value;
                }
                else
                {
                    Console.WriteLine("Day is Invalid defaulting to 1");
                    _Day = 1;
                }
                
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Day + "/" + Month + "/" + Year;
        }

        public static int GetDifference(Date y1, Date y2)
        {

            return y1.Year - y2.Year;
        }

        public static String GetDifference(DateTime y1, Date y2)
        {

            int age = y1.Year - y2.Year;

            return "person's age is " + age;
        }

        public void acceptDetails()
        {
            Console.WriteLine("enter year");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Month");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter day");
            Day = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion




    }
}
