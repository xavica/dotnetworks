using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiInhr
{
    class Program
    {
        static void Main(string[] args)
        {
            inheri obj = new inheri();
            obj.mode();
            obj.feature();
            obj.Noise();
            Console.Read();
        }
        class inheri : vehicle
        {
            public void Noise()
            {
                Console.WriteLine("All Vehicles Creates Noise !!--> I AM GRAND PARENT ");
            }
            
        }
        class Mode
        {
            public void mode()
            {
                Console.WriteLine("There are Many Modes of Transport !! --> I AM CHILD");
            }
        }
        class vehicle : Mode
        {
            public void feature()
            {
                Console.WriteLine("They Mainly Help in Travelling !! --> I AM PARENT");
            }
        }
    }
}
