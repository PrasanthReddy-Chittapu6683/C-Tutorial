# C# - Top 100 Interview Questions


1. ### What is C-Sharp (C#)
    C# is a type-safe, managed and object oriented language, which is compiled by .Net framework for generating intermediate language (IL).
1. ### Explain the features of C#?
    Below are some of the features supported in C# -
    *  Constructors and Destructors
    *  Properties
    *  Passing Parameters
    *  Arrays
    *  Main
    *  XML Documentation and
    *  Indexers  
1. ### List some of the advantages of C#?
    Below are the advantages of C# -
    *  Easy to learn
    *  Object oriented
    *  Component oriented
    *  Part of .NET framework
1. ### What are IDE’s provided by Microsoft for C# development?
    Below are the IDE’s used for C# development –
    *  Visual Studio Express (VCE)
    *  Visual Studio (VS)
    *  Visual Web Developer
1. ### Explain the types of comments in C#?
    Below are the types of comments in C# 
    *  Single Line Comment Eg : //
    *  Multiline Comments Eg: /* */
    *  XML Comments Eg : ///
1. ### Explain sealed class in C#?
    Sealed class is used to prevent the class from being inherited from other classes. So __`sealed`__ modifier also can be used with methods to avoid the methods to override in the child classes.
1. ### Give an example of using sealed class in C#?
    Below is the sample code of sealed class in C# -
    
    ```javascript
      class X {} 
      sealed class Y : X {}

      Sealed methods –

      class A
      {
       protected virtual void First() { }
       protected virtual void Second() { }
      }
      class B : A
      {
       sealed protected override void First() {}
       protected override void Second() { }
      }
    ```
    If any class inherits from class “B” then method – “First” will not be overridable as this method is sealed in class B.
1. ### List out the differences between Array and ArrayList in C#?
    * Array stores the values or elements of same data type but arraylist stores values of different datatypes.
    * Arrays will use the fixed length but arraylist does not uses fixed length like array.
1. ### Why to use “using” in C#?
    __`Using`__ statement calls – __`dispose`__ method internally, whenever any exception occurred in any method call and in __`Using`__ statement objects are read only and cannot be reassignable or modifiable.
1. ### Explain namespaces in C#?
    Namespaces are containers for the classes. We will use namespaces for grouping the related classes in C#. __`Using`__ keyword can be used for using the namespace in other namespace.
1. ### Static Constructor?
    *   These are used to initilize static fields in a class.
    *   Can declare a static constructor by using the keyword static infront of the constructor name.
    *   Static Constructor is __`called only once`__. No matter how many instances you create.
    *   These are called before the instance constructore(ie., Instance / non static constructor)
    *   Static Constructor will call before the Class inititalize (ex: No need to initialize to execute static constructor  >>> Circle c1 = new Circle())

   ``` javascript
    class Circle {
        static Circle() {
            Console.log("Static Constructor called")
        }
        public Circle() {
            Console.log("Instance Constructor called")
        }
    }
    class Program {
        public static void main() {
            Circle C1 = new Circle();
            Circle C2 = new Circle();
        }
    }

    Output:
    >>> Static Constructor called
    >>> Instance Constructor called
    >>> Instance Constructor called
   ```
1. ### What is the use of `base` keyword?
    *   When a Parent class have multiple constructors with diffent parameters. Now we need to execute any one constructors are default.
    *   using `base` keyword we can decide to execute which Constructor need to call in Parent class.
    *   `base` keyword will give options to select any of the constructors which need to call in the parent.
    
    ``` javascript
        Class Parent {
            
            public Parent() { // This constructor will called by default
                Console.log("Non Parameterized constructor")
            }

            public Parent(string message) {
                Console.log("Parameter Constructor : "+ message)
            }
        }

        Class ChildClass : Parent {
            public ChildClass() : base("Am making  Parameterized Constructor as Default constructor using base keyword"){
                Console.log("Child Class constructor")
                
            }
        }
    
    ```


1. ### Method Hiding?
    *   
1. ### Item 3b
1. ### Item 3
1. ### Item 3a
1. ### Item 3b
1. ### Item 3
1. ### Item 3a
1. ### Item 3b
1. ### Item 3
1. ### Item 3a
1. ### Item 3b
