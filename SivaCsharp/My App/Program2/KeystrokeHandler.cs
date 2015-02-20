using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2
{
    public delegate void KeypressDelegate(char key);
    public delegate void QuitDelegate();


    public class KeystrokeHandler
    {
        public KeypressDelegate OnKey;   
        public QuitDelegate OnQuitting;
        public void Run()
        {
            Console.WriteLine("Keystroke Handler is running. Press q to quit.");
            while(true)
            {
                char key = Console.ReadKey(true).KeyChar;

                if ('q' == key)
                {
                    if (null != OnQuitting)
                        OnQuitting();
                    break;
                }
                    
                if (null != OnKey)
                    OnKey(key);
            }
        }
    }
}
