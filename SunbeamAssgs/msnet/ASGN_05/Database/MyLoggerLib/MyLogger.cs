using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyLoggerLib
{
    public class MyLogger : ILogger
    {
        private static MyLogger _logger = new MyLogger();

        private MyLogger()
        {
            Console.WriteLine("Logger Object is created");
        }

        public static MyLogger CurrentLogger
        {
            get
            {
                return _logger;
            }
        }


        public void Log(string message)
        {
            Console.WriteLine( DateTime.Now.ToString() + " , "  + message);

            string filename = "Log" + DateTime.Now.ToString("ddMMyyyy") + ".csv";

            string str = DateTime.Now.ToString() + " , " + message;

            

            #region Normal File Writing
            FileStream fs = new FileStream(@"F:\Dhiraj C-DAC\CDAC_My_Work\d8_36101_dhiraj_msnet\assignment\ASGN_05\" + filename,
                                            FileMode.Append,
                                            FileAccess.Write);

            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine(str);

            fs.Flush();
            writer.Close();
            fs.Close();
            #endregion
        }
    }
}
