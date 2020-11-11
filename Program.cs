using System;

namespace ConsoleApp1
{



    public abstract class myAb
    {
        public abstract string printString(string name);
       public  int EmpId;
        public void EmpDtls()
        {
            Console.WriteLine("Inside Ab");
        }
    }

    
    class Program : myAb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Singleton fromEmp = new Singleton();
            //fromEmp.printSingletonMessages("This is from Emp ");

            //Singleton fromStud = new Singleton();
            //fromStud.printSingletonMessages("This is from Student");

            myAb m = new Program();
            m.EmpDtls();
            m.printString("Prcv");
            m.EmpId = 10;


        }
        public override string printString(string name)
        {
            Console.WriteLine("My Name:" + name);
            return name;
        }

    }
}
