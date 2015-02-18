using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b; 
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public Double ComputPi(int numDecimalplaces, out TimeSpan duration)
        {
            duration = TimeSpan.FromSeconds(10);
            return 3.14;
        }
        public Double AddTheseNumbers(params Double[] array)
        {
            Double sum = 0.0;
            foreach (double value in array)
                sum += value;
            return sum;
        }
    }
}
