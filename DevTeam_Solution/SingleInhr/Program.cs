﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleInhr
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher d = new Teacher();
            d.Teach();
            Student s = new Student();
            s.Learn();
            s.Teach();
            Console.ReadKey();
        }
        class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teach:This is Parent");
            }
        }
        class Student : Teacher
        {
            public void Learn()
            {
                Console.WriteLine("Learn:This is Child");
            }
        }
    }
        }
    

