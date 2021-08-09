using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Inheritance
{
    class Dog : Animal
    {

        public string Color { get; set; }

        public Dog(string name, int num, string color)
            :base(name,num)
        {
           
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("{0} is barking",Name);
        }
        public override void DisplayAge()
        {
            Console.WriteLine("{0} is {1} from dog class yearssssss old", Name, Age);
        }
    }
}
