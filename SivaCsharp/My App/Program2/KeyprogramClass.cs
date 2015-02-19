using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2
{
    class KeyprogramClass
    {
        static void Main(string[] args)
        {
            KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
            keystrokeHandler.Run();
            Console.ReadLine();
        }
    }
}
