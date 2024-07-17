using MultilevelInheritanceApp.Models;

namespace MultilevelInheritanceApp
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Square myShape = new Square();
            myShape.Draw();
            myShape.Move();
            myShape.Resize();
            myShape.CalculateArea();

        }
    }
}
/*Inheritance allows the derived classes to inherit properties , methods and behaviours of the base 
 classes and to add new features or functionalities to the derived classes.
 ->allows code reuse, increases code organization, and simplifies the development process
->Multilevel inheritance in C# refers to a scenario where a class is derived from a class which is also derived from another class. */