using System;
using System.Collections.Generic;
using System.Text;

namespace task_2_ieee
{
    public class Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        { 
            Name = name; 
            Age = age; 
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, {Age} years old.");
        }
    }
}
