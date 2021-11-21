using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib
{
    public class Class1
    {
    }
}

namespace BasicNS
{
    public class BasicCalculator
    {
        public int add(int x , int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int mul(int x, int y)
        {
            return x * y;
        }

        public int div(int x, int y)
        {
            return x / y;
        }


    }
}

namespace TempratureNS
{
    public class TempratureConverter
    {
        public double FarenheitToCelcius(double x)
        {
            double result = ((x - 32) * (5.0 / 9.0));

            return result;
        }

        public double CelciusToFarenheit(double x)
        {
            double result = ((x * (9.0 / 5.0)) + 32);

            return result;
        }
    }
}
