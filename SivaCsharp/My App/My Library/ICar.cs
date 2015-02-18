using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Library
{
    public interface ICar
    {
        void Start();
        void PreAccelerator(Double howFar);
        void PressBrake(double pressure);

        string Make { get; }
        string Model { get; }
        int Year { get; }
         
            
    }
}
