namespace ASSIGNMENT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("===== ASSIGNMENT 2 MAIN MENU =====");
                Console.WriteLine("1. Inheritance and Method Overriding");
                Console.WriteLine("2. Abstract Classes and Methods");
                Console.WriteLine("3. Interfaces");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                bool isValid = int.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine();

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ASSIGNMENT2.InheritanceMethodOveride.InheritanceMethodOveride.Run();
                        break;
                    case 2:
                        ASSIGNMENT2.AbstractClasses.AbstractClasses.Run();
                        break;
                    case 3:
                        ASSIGNMENT2.Interfaces.Interfaces.Run();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                }

            } while (choice != 0);
        }
    }
}
