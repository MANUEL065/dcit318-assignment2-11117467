namespace ASSIGNMENT2.Interfaces
{
    public class Interfaces
    {
        public static void Run()
        {
            Console.WriteLine("=== Interfaces ===");

            IMovable car = new Car();
            car.Move();

            IMovable bicycle = new Bicycle();
            bicycle.Move();
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
