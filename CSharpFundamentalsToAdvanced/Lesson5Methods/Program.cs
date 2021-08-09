using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number for squers");
            double data1 = double.Parse(Console.ReadLine());
             
           
            double result = Exercise.squeres(data1);
            Console.WriteLine(" the squere of  {0} * {1} = {2}",data1,data1,result);

           
            Console.WriteLine("Enter a number for cube");
            double data5 = double.Parse(Console.ReadLine());
            double cubeResult = Exercise.cube(result, data5);
            Console.WriteLine(cubeResult);

            //SayHello("Hello Worlder");
            //Add(10, 10);
            //DisplaySalesTax(33);
            //ADD(58, 77);
            //int answer =NewAdd(88, 55);

            //int[] myArray = { 1,5,10,15,20} ;

            //AddThree(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
        }
        //private static void AddThree(int[] number)
        //{
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        number[i] += 3;
        //    }
        //}
        //private static void ADD(int x,int z)
        //{
        //    int answer = x + z;
        //    Console.WriteLine("{0}+{1}={2}", x,z,answer);
        //}
        //private static int NewAdd(int x, int y)
        //{
        //    int answer = x + y;
        //    return answer;
        //}

        //private static void DisplaySalesTax(double salesAmount)
        //{
        //    const double RATE = 0.25;
        //    double tax = salesAmount * RATE;
        //    Console.WriteLine("the tax on  {0} is {1}", salesAmount.ToString("C"),tax.ToString("C"));
        //}
        //private static void SayHello(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //private static void Add(int x, int y)
        //{
        //    int answer = x + y;
        //    Console.WriteLine("{0} +{1} ={2}",x,y,answer);
        //}
    }
}
