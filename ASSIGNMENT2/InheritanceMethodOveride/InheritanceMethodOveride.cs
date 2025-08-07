namespace ASSIGNMENT2.InheritanceMethodOveride
{
    public class InheritanceMethodOveride
    {
        public static void Run()
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal generic = new Animal();
            generic.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
