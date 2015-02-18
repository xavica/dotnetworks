using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c;
            Addit ad=new Addit();
            c = ad.add(a, b);
            Console.WriteLine("Addition of two numbers is :" + c);
            Console.ReadLine();

        }
    }
}
