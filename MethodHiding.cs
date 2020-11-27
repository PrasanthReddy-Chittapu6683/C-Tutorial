using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class MethodHidingEmployee
    {
        public string fistName;
        public string lastName;

        public void printFullname()
        {
            Console.WriteLine(fistName + " " + lastName);
        }
    }

    public class PartTimeEmployee : MethodHidingEmployee
    {
         
    }
    public class FullTimeEmployee : MethodHidingEmployee
    {

    }


}
