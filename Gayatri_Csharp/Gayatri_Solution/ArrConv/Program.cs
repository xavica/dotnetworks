﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using My_Library_G;
namespace ArrConv
{
    public class Program
    {
       static void Main(string[] args)
        {
            Twodmatrix obj = new Twodmatrix(2, 3);
            Console.WriteLine("Enter the Elements : ");
            obj.readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.printd();
            obj.convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }
    }
    
    }


