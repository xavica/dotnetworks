using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2
{
    public class KeystrokeHandler
    {
        public void Run()
        {
            Console.WriteLine("Keystroke Handler is running. Press q to quit.");
            while(true)
            {
                char key = Console.Readkey(true).KeyChar;

                if ('q' == key)
                    break;
            }
        }
    }
}
