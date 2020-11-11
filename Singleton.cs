using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ConsoleApp1
{
    class Singleton
    {
        private static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine("This is Counter in Singleton Class Constructor : " + counter);
        }
        public void printSingletonMessages(string msg)
        {
            Console.WriteLine(msg);

        }
    }
}
