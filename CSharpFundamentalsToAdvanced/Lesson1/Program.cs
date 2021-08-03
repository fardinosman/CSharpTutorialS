using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //intance of the class 
            UsingData usingData = new UsingData();

            Console.WriteLine(usingData.myAge = 22);
            Console.WriteLine(usingData.myMoney = 22);
            Console.WriteLine(usingData.myName = "Hello");

            Console.WriteLine("The money is $ {0} and my name is {1} and my iam {2} years old", usingData.myMoney,
                usingData.myName, usingData.myAge);
            
            Console.WriteLine(usingData.experi());

            usingData.numbers();

            Console.WriteLine("----------- encrement decrement counter exsample");
            int counter = 5;
            Console.WriteLine(counter );
            Console.WriteLine(counter =  + 1);
            Console.WriteLine(counter +=  1);
            Console.WriteLine( counter = counter+1);
            Console.WriteLine(counter++);
            Console.WriteLine(++counter);
            Console.WriteLine(counter--);
            Console.WriteLine(--counter);
            Console.WriteLine("-------------bool data type it can only hold 2 value and its value type its either true or false 1 or 0");
            bool iItMonday = false;
            bool areyouTired = true;
            Console.WriteLine("--------------------------Comparsion operator with bool operator > < !> !> != ==");

            int num1 = 5;
            int num2 = 6;
            bool mybool = num1 > num2;
            mybool = num1 < num2;
            mybool = num1 <= num2;
            mybool = num1 == num2;
            mybool = num1 != num2;
            Console.WriteLine(mybool);

            Console.WriteLine("-------------------------------Int- casting Double-----Decimal----Long--------------------------");
            double myDouble = 5.5;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);

            Console.WriteLine("-------------char---------exsample char hold single character----------");

            char myChar = 'H';
            Console.WriteLine(myChar);
            char mySecondChar = '8';
            Console.WriteLine(mySecondChar);
            Console.ReadLine();
        }
    }
}
