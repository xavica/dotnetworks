using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    public class Polo:ICar
    {
        public void Start()
        {
            Console.WriteLine("Click Click Click Click Click ");
        }

        public void PreAccelerator(double howFar)
        {
            if (howFar < 9)
            {
                //nothing happens
            }
            else Console.WriteLine("Cough!!!!!!!!");
        }

        public void PressBrake(double pressure)
        {
            if (pressure < 5)
            {
                Console.WriteLine("Squeeeeeeeeek");
            }
            else Console.WriteLine("Grrrrrrrrriiiiiiiiinnnnnnnnnddddddddd");
        }

        public string Make
        {
            get { return "Volkswagen"; }
        }

        public string Model
        {
            get { return "Polo"; }
        }

        public int Year
        {
            get { return  2014; }
        }
    }
}
