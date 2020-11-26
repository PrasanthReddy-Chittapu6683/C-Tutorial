using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /** “One should depend upon abstractions, [not] concretions.”
     * The dependency inversion principle (DIP) has two parts:
        1. High-level modules should not depend on low-level modules. Instead, both should depend on abstractions (interfaces)
        2. Abstractions should not depend on details. Details (like concrete implementations) should depend on abstractions.
     * The first part of this principle reverses traditional OOP software design. Without DIP, programmers often construct programs to have high-level
       (less detail, more abstract) components explicitly connected with low-level (specific) components to complete tasks.
     * DIP decouples high and low-level components and instead connects both to abstractions. High and low-level 
       components can still benefit from each other, but a change in one should not directly break the other.
     * The advantage of this part of DIP is that decoupled programs require less work to change. Webs of dependencies across your 
       program mean that a single change can affect many separate parts.
     
     * The second part can be thought of as “the abstraction is not affected if the details are changed”. The abstraction is the user-facing part of the program.
     * The details are the specific behind-the-scenes implementations that cause program behavior visible to the user. 
       In a DIP program, we could fully overhaul the behind-the-scenes implementation of how the program achieves its behavior without the user’s knowledge.

     * This process is known as refactoring.
     */
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name - " + id;
        }you
    }
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
    class SOLID_PRINCIPLES_DIP
    {
    }
}
