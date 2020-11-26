using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /** “Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.”
     * The principle says that any class must be directly replaceable by any of its subclasses without error.
     * In other words, each subclass must maintain all behavior from the base class along with any new behaviors unique to the subclass. 
       The child class must be able to process all the same requests and complete all the same tasks as its parent class.
     * In practice, programmers tend to develop classes based on behavior and grow behavioral capabilities as the class becomes more specific. 
       The advantage of LSP is that it speeds up the development of new subclasses as all subclasses of the same type share a consistent use.
     * You can trust that all newly created subclasses will work with the existing code. 
       If you decide that you need a new subclass, you can create it without reworking the existing code.
     */
    public abstract class Fruits
    {
        public abstract string getColor();
    }
    public class Apple : Fruits
    {
        public override string getColor()
        {
            return "Red";
        }
    }

    public class Orange : Fruits
    {
        public override string getColor()
        {
            return "Orange";
        }
    }

}
