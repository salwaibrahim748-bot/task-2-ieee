using System;
using System.Collections.Generic;
using System.Text;

namespace task_2_ieee
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Developer(string name, int age, int id, decimal salary, string programmingLanguage)
            : base(name, age, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public void Code()
        {
            Console.WriteLine($"{Name} is writing {ProgrammingLanguage} code.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I am a Developer and I write {ProgrammingLanguage}.");
        }
    }
}
