using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace My_Library
{
    public abstract class Car
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }


        public  virtual void Start();
    {
        Console.WriteLine("Roarrrrrrrrrrr");
    
public  string Make { get; set; }
public  string Model { get; set; }
public  int Year { get; set; }}
        public abstract void PreAccelerator(Double howFar);
        public  abstract void PressBrake(double pressure);

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
         
            
    }
}
