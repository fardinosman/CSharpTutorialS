using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of students");
            int numberOFStudents = int.Parse(Console.ReadLine());
            double[] myStudents = new double[numberOFStudents];
            for (int i = 0; i < myStudents.Length; i++)
            {
                Console.WriteLine("Enter grade for student #{0}\n",i+1);
                myStudents[i] = double.Parse(Console.ReadLine());
            }
            double average = 0;
            for (int i = 0; i < myStudents.Length; i++)
            {
                average += myStudents[i];
                Console.WriteLine("\nstudent #{0}: {1}\n", i +1, myStudents[i]);
            }

            Console.WriteLine("\nThe Class average is :{0}",average /myStudents.Length);

            //string[] names = { "Olive", "Patty", "Richard", "Richard", "Ned", "Mindy" };
            //Array.Reverse(names);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            ////int[] validvalues = { 101, 108, 201, 213, 555, 66, 888, 233, 456 };
            ////double[] pricesarr = { 0.89, 1.08, 2.01, 2.13, 5.55, 6.6, 88.8, 2.33, 4.56 };

            ////console.writeline("enter a order number");
            ////int ordernumber = int.parse(console.readline());
            ////bool iteminstock = false;
            ////double price =0;


            ////for (int i = 0; i < validvalues.length; i++)
            ////{
            ////    if (ordernumber == validvalues[i])
            ////    {
            ////        price = pricesarr[i];
            ////        iteminstock = true;
            ////        break; 
            ////    }
            ////}
            ////if (iteminstock ==true)
            ////{
            ////    console.writeline("the item is in stock, and the price is {0}", price.tostring("c"));
            ////}
            ////else
            ////{
            ////    console.writeline("sorry the item is not in stock");
            ////}


            //int[] myFirstArray = new int[3];
            ////its similiar to int x = 8; int y = 1, int z = 4

            //myFirstArray[0] = 5;
            //myFirstArray[1] = 3;
            //myFirstArray[2] = 4;

            //int[] mySecondArray = new int[] { 100, 22, 44, 50,90,55,43,63,213,434 };

            //int[] thirdwayArrya = new int[] { 4, 5, 6 };

            //int[] myLastArray = { 100, 200, 300 };

            //int[] score = { 100, 200, 76, 88, 44, 90 ,56, 454, 3443 };


            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine(score[0] += 3);
            //}
            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine("student  #{0}: {1}", i ,score[i]);
            //}
        }
    }
}
