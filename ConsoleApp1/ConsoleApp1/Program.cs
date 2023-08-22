using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero lion = new Lion("Sherxon", 20, 60, 10);
            lion.Display();
            lion.Run();

            Console.WriteLine("\n");

            Hero murlock = new Murlock("Chiya bo'ri", 5, 35, 20);
            murlock.Display();
            murlock.Run();
            murlock.Attack();
        }
    }
}