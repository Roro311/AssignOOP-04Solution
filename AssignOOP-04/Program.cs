namespace AssignOOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            //Q1 Abstraction
            //a)  What is Abstraction in Object - Oriented Programming?
            // answer: Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that focuses on exposing only the essential features of an object while hiding the unnecessary details.
            // It allows developers to create simplified models of complex systems by defining abstract classes or interfaces that specify the behavior and properties that derived classes must implement.
            // This helps in managing complexity, improving code maintainability, and promoting code reusability.

            //b)  Why is abstraction considered one of the four pillars of OOP?
            // answer: Abstraction is considered one of the four pillars of OOP because it allows developers to create simplified models of complex systems by focusing on essential features and hiding unnecessary details.


            //Q2  Abstract Classes vs.Interfaces
            //a)  What is the difference between an Abstract Class and an Interface?
            // answer: An Abstract Class is a class that cannot be instantiated and may contain both abstract methods (without implementation) and concrete methods (with implementation).
            // It serves as a base class for other classes to inherit from, allowing for code reuse and providing a common interface for related classes.

            //b)  When would you choose an Interface instead of an Abstract Class?
            // answer: I would choose an Interface when you want to define a contract that multiple classes can implement, allowing for multiple inheritance of behavior.
            // An abstract class is more suitable when you want to provide a common base implementation for related classes.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // answer: A class in C# can only inherit from one abstract class (single inheritance), but it can implement multiple interfaces (multiple inheritance of contract).

            #endregion
        }
    }
}
