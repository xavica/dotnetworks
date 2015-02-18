using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    public class M3: ICar
    {
        public void Start()
        {
            Console.WriteLine("Roar");
        }

        public void PreAccelerator(double howFar)
        {
            Console.WriteLine("Vroom Vroom!!!!!!!!!");
        }

        public void PressBrake(double pressure)
        {
            Console.WriteLine("Car has Stopped on a time");
        }

        public string Make
        {
            get { return "Mercedes Benz"; }
        }

        public string Model
        {
            get { return "mercedes Benz CLA"; }
        }

        public int Year
        {
            get { return 2015 ; }
        }
    }
}
