using System;
using ASSIGNMENT2.InheritanceMethodOveride; // Import the namespace of your Animal classes

namespace ASSIGNMENT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal generic = new Animal();
            generic.MakeSound(); // Some generic sound

            Animal dog = new Dog();
            dog.MakeSound(); // Bark

            Animal cat = new Cat();
            cat.MakeSound(); // Meow
        }
    }
}
