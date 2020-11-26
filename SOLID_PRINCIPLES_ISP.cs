using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /** “Many client-specific interfaces are better than one general-purpose interface.”
     * It requires that classes only be able to perform behaviors that are useful to achieve its end functionality. 
       In other words, classes do not include behaviors they do not use.
     
     * The advantage of ISP is that it splits large methods into smaller, more specific methods. This makes the program easier to debug for three reasons:
        1.  There is less code carried between classes. Less code means fewer bugs.
        2.  A single method is responsible for a smaller variety of behaviors. 
            If there is a problem with a behavior, you only need to look over the smaller methods.
        3.  If a general method with multiple behaviors is passed to a class that doesn’t support all behaviors 
            (such as calling for a property that the class doesn’t have), there will be a bug if the class tries to use the unsupported behavior.
        Ex: In the below example IFullTimeWorkerSalary & IContractWorkerSalary interface is having "CalculateNetSalary()" for Fulltime employees  and 
            "CalculateWorkedSalary()" for Contract employees. Both methods cannot add in single 1 interface.
     
     
     */
    class SOLID_PRINCIPLES_ISP
    {
    }
    public interface IBaseWorker
    {
        int ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
    public interface IFullTimeWorkerSalary : IBaseWorker
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float CalculateNetSalary();
    }
    public interface IContractWorkerSalary : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateWorkedSalary();
    }

    public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    }

    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
    }

}
