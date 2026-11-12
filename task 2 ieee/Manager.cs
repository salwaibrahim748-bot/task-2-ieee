using System;
using System.Collections.Generic;
using System.Text;

namespace task_2_ieee
{
    public class Manager : Employee
    {
        public List<Developer> Team { get; set; }
        public Manager(string name, int age, int id, decimal salary) : base(name, age, id, salary)
        {
            Team = new List<Developer>();
        }
        public void AddToTeam(Developer dev)
        {
            Team.Add(dev);
        }
        public void ShowTeam()
        {
            Console.WriteLine($"Manager {Name} leads {Team.Count} developers.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I am a Manager and I lead {Team.Count} developers.");
        }
    }
}
