using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // this called is a relation becuase dog is a animal
            Animal a1 = new Animal("dogg",34);
        
            a1.DisplayAge();

            Dog d1 = new Dog("dsd",4,"Blue");
           
            d1.DisplayAge();
            d1.Bark();  

            TakeinAni(d1);
        }
        private static void TakeinAni(Animal a)
        {
            if (a is Dog)
            {
                Dog myDog = a as Dog;
                Console.WriteLine(myDog.Color);
            }
            else
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
