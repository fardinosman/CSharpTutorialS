using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class UsingData
    {
        public int myAge = 50; // int is value type
        public double myMoney = 5.5; // double is value type
        public string myName = "Fardin"; // string is reference type

        int x = 5;
        int y;
        int modules = 10 % 3;//how many times it goes to 10 and rest is reminder

        //operater precedence
        //multication has higer precedence
        //multi is first then division / - and +
        int result = (2 + 3) * 4;

        int counter = 5;
        //counter= counter +1;
        
        public int experi()
        {
             y = 6 + x ;
            return  y ;
        }

        public void numbers()
        {
            int x = 5;
            int y = x * 5;
            int z = x / 5;
            Console.WriteLine("The value of x is  {0}" , x); 
            Console.WriteLine("The value of y is  {0}",y ); 
            Console.WriteLine("The value of z is  {0}",z);

            Console.WriteLine(result);

            Console.WriteLine();
        }
    }
}
