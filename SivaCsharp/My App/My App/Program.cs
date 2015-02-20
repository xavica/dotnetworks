using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using My_Library;
 
namespace MyApp
{
   public class Program 
    {
        static void Main(string[] args)
        {
           //performing Arthemitic operations 

            Console.WriteLine(" Hello world");

            Calculator calc = new Calculator();

            double Addition = calc.Add(25,5 );

            Console.WriteLine("25+5={0}", Addition);

            double Subtration = calc.Sub(25, 5);

            Console.WriteLine("25-5={0}", Subtration);

            double Multiplication = calc.Mul(25, 5);

            Console.WriteLine("25*5={0}", Multiplication);

            double Division = calc.Div(25, 5);

            Console.WriteLine("25/5={0}", Division);

             
            //Displaying DateTime
            DateTime now = DateTime.Now;
            now = now.AddDays(0);
            Console.WriteLine("{0}", now);
            Console.WriteLine("{0:d}",now);
            Console.WriteLine("{0:MMM dd yyyy}",now);
            //defineing pi and passing params
            TimeSpan ts;
            double pi = calc.ComputPi(0, out ts);
            Console.WriteLine("{0} was computed in {1} seconds", pi, ts.TotalSeconds);
            //double[] addThese={1.1,2.2,3.3,4.4};
            Console.WriteLine("Sum of the given numbers is " + calc.AddTheseNumbers(1.1, 2.2, 3.3, 4.4));
            Console.WriteLine("please press enter once");
            Console.ReadLine();
            
           ////using icar interface
            ICar[] cars = {new M3(), new Polo(),};
            foreach (ICar car in cars)
            {
                PrintCarInfo(car);
                car.Start();
                car.PreAccelerator(2);
                car.PreAccelerator(10);
                car.PressBrake(2);
                car.PressBrake(10);
                Console.ReadLine();
               
            }
        }
        //defining a  car using interfaces
        static void PrintCarInfo(ICar car)
        {
            Console.WriteLine("Here is a {0} {1} {2} ", car.Year, car.Make, car.Model );
           
        }
      
    }
}
