using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class values
    {
        private int[] val = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        public int Length
        {
            get { return val.Length; }
        }
        public int this[int index]
        {
            get
            {
                return val[index];
            }

            set
            {
                val[index] = value;
            }
        }
    }
}
