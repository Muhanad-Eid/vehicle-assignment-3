
namespace Vehicle_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Car car = new Car("Toyota");
         Motorcycle bike = new Motorcycle("Honda");
            Console.WriteLine();
            car.Stop();
            car.Start();
            car.Log("This is a log message");
            Console.WriteLine(car.CalculateFuelConsumption(10));
            bike.Stop();
            bike.Start();
            Console.WriteLine(bike.CalculateFuelConsumption(10));
        }
    }
}
