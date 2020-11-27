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

            #region Liskov substitution principle (LSP) 

            Fruits fruit = new Orange();
            Console.WriteLine("Orange Color is :"+ fruit.getColor());
            fruit = new Apple();
            Console.WriteLine("Apple Color is :" + fruit.getColor());
            #endregion


            #region Interface segregation principle
            ContractEmployeeFixed cEmp = new ContractEmployeeFixed();
            cEmp.ID = 1;
            cEmp.Name = "PRASANTH";
            cEmp.Email = "PRASANTH@gaas.com";
            cEmp.HourlyRate = 10;
            cEmp.HoursInMonth = 200;
            Console.WriteLine("Contact employee Id - " + cEmp.ID + " Name: " + cEmp.Name + " Email - " + cEmp.Email + " Amount is :" + cEmp.CalculateWorkedSalary());


            FullTimeEmployeeFixed fEmp = new FullTimeEmployeeFixed();
            fEmp.ID = 2;
            fEmp.Name = "PRCV";
            fEmp.Email = "PRCV@gaas.com";
            fEmp.MonthlySalary = 1200000;
            fEmp.OtherBenefits = 60000;
            Console.WriteLine("Fulltime employee Id - " + fEmp.ID + " Name: " + fEmp.Name + " Email - " + fEmp.Email + " Amount is :" + fEmp.CalculateNetSalary());
            #endregion

            CustomerBusinessLogic cbl = new CustomerBusinessLogic();
            Console.WriteLine("Dependency Injection Prinicple - " + cbl.GetCustomerName(101));


            Console.WriteLine(">>>>>>>>>>>> Method Hiding <<<<<<<<<<<<<<<<");
           FullTimeEmployee fte = new FullTimeEmployee();
            fte.fistName = "Prasanth";
            fte.lastName = "Reddy";
            fte.printFullname();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.fistName = "PRCV";
            pte.lastName = "R";
            pte.printFullname();
        }
        public override string printString(string name)
        {
            Console.WriteLine("My Name:" + name);
            return name;
        }






    }
}
