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
            QuitTracker jagan =new QuitTracker{Name= "Jagnan"};
            QuitTracker siva = new QuitTracker { Name = "Siva" };
            KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
            keystrokeHandler.OnKey = GotKey;
            keystrokeHandler.OnQuitting = jagan.QuitHandler;
            keystrokeHandler.OnQuitting += siva.QuitHandler;
            keystrokeHandler.OnQuitting += OnQuit;
            keystrokeHandler.OnQuitting();
            keystrokeHandler.OnQuitting = null;




            keystrokeHandler.Run();            
        }
        static void GotKey(char key)
        {
            Console.WriteLine("Got a key : {0}",key);

        }
        static void OnQuit()
        {
            Console.WriteLine("Quitting");
            Console.ReadLine();
        }
    }

    public class QuitTracker
    {
        public string Name { get; set; } 
        public void QuitHandler()
        {
            Console.WriteLine("My name is {0} and I just got quit notification", Name);
            Console.ReadLine();
        }
    }

}

