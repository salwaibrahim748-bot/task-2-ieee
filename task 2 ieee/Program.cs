namespace task_2_ieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Sara", 35, 1, 10000);
            Developer dev1 = new Developer("Omar", 24, 2, 8000, "C#");
            Developer dev2 = new Developer("Ali", 26, 3, 8500, "Python");

            manager.AddToTeam(dev1);
            manager.AddToTeam(dev2);

            manager.Introduce();
            dev1.Introduce();

            manager.RaiseSalary(10);
            dev1.RaiseSalary(10);
            Console.WriteLine($"Salary after raise: {manager.Salary}");

        }
    }
}
