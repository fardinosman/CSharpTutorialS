using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessen2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 6;
            //if (x == 5)
            //    Console.WriteLine("X is 5");
            //   Console.WriteLine("X is 5");
            //   Console.WriteLine("X is 5");

            //int number = 5;
            //if (number ==5)
            //{
            //    Console.WriteLine("A");
            //    Console.WriteLine("B");
            //}

            //bool myBool = true;
            //if (myBool == false)
            //{
            //    Console.WriteLine("my boo is true");
            //}
            //const int LOW = 5;
            //const int HIGH = 10;

            //Console.WriteLine("Enter a number");

            //int value = Convert.ToInt32(Console.ReadLine());

            //if (value > LOW)
            //{
            //    if (value < HIGH)
            //    {
            //        Console.WriteLine("{0} is between  {1} and {2}",value,LOW,HIGH);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("enter number between {0} and {1}",LOW,HIGH);
            //}
            //Console.WriteLine("-----------nested if ---------------");
            //int z = 3;
            //bool Booly = false;
            //if (z==6)
            //{
            //    if (Booly == true)
            //    {
            //        Console.WriteLine("Hellow");
            //    }
            //    else
            //    {
            //        Console.WriteLine("heloo");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Bye");
            //}

            //Console.WriteLine("Enter a number");

            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n > HIGH)
            //{
            //    Console.WriteLine("{0} is greater than {1}", n,HIGH);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not greater than {1}", n, HIGH);
            //}
            //Console.WriteLine("Compartion Operator -----&&---´´----|| OR-------------------------");
            //int a = 5;
            //int b = 6;
            //if (a ==5||b==7)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //Console.WriteLine("another && and ||  < > exsample");

            //Console.WriteLine( "Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //if (age > 10 || name  =="tim")
            //{
            //    Console.WriteLine("Good time to marry");
            //}
            //else
            //{
            //    Console.WriteLine("Not good");
            //}
            //Console.WriteLine("Enter a year");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if (year ==1)
            //{
            //    Console.WriteLine("eid");
            //}
            //else if(year==2)
            //{
            //    Console.WriteLine("qurban");
            //}
            //else if (year == 3)
            //{
            //    Console.WriteLine("ramazan");
            //}
            //else
            //{
            //    Console.WriteLine("not match found");
            //}
            //Console.WriteLine("---------------------------Switch-------------------");

            //switch (year)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("ramazan");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("shaban");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("eid");
            //            break;
            //        }
            //    case 4: 
            //        {
            //            Console.WriteLine("qurban");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("no match found");
            //          break;
            //        }  

            //}
            Console.WriteLine("-------Program Task-----");

            Console.WriteLine("lawn-mowing service");
            Console.WriteLine("Please enter the lengdt");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number week");
            double week = Convert.ToDouble(Console.ReadLine());

            double mowing = length * width;

            double weeklyPrice=0;
          


            if (mowing<=400 )
            {
                weeklyPrice = 25;
              
            }
            else if (mowing > 400 && mowing <=600 )
            {
                weeklyPrice = 35;
           
            }
            else if (mowing > 600 )
            {
                weeklyPrice = 50;
               
            }

            double seasonPrice = weeklyPrice * 20;
            Console.WriteLine(" weekly price is ${0} ", weeklyPrice);
            Console.WriteLine("total fee for 20-week season is ${0}",seasonPrice);

            Console.ReadKey();
        }
    }
}
