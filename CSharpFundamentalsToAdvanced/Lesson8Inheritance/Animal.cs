using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayAge()
        {
            Console.WriteLine("{0} is {1} years old", Name , Age);
        }
    }
}
