using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            values newval = new values();
            newval[3] = 58;
            newval[5] = 60;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Element #{0} = {1}", i, newval[i]);
            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
