using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6MethodConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            //its reference type 
            //int[] value = { 4 ,6,7,8,6};

            //DisplayValueParameter(value);

            //Console.WriteLine("After function call");
            //for (int i = 0; i < value.Length; i++)
            //{
            //    Console.WriteLine(value[i]);
            //}
            //------------------------------------------------------------------
            //int first;
            //int second;
            //InputMethod(out first, out second);
            //Console.WriteLine(  first);
            //Console.WriteLine(second);
            //Add(4, 4);
            //Add("fard", "din");
            //Add(true,false);
            Hello("Hello");
            DisplaySize(1,2,3);
            DisplaySize(1, 2);
            DisplaySize(1);
            DisplaySize(1, heigth: 5);
            DisplaySize(heigth: 1, length: 2, width: 3);

        }
        //optional parameter
        private static void DisplaySize(int length , int width = 2, int heigth = 1)
        {
            int area = length * width * heigth;
            Console.WriteLine("Size is {0}", area);
        }
        private static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        private static void Add(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }

        private static void Add(bool v)
        {
            throw new NotImplementedException();
        }

        private static void Add(int x , int y)
        {
            Console.WriteLine(x + y) ;
        }
        private static void Add(string x, string y)
        {
            Console.WriteLine(x + y);
        }
        

        //private static void InputMethod(out int one, out int two)
        //{
        //    Console.WriteLine("Enter the first integer");
        //    one = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the second integer");
        //    two = int.Parse(Console.ReadLine());
        //}

        //private static void DisplayValueParameter(int[] value)
        //{
        //    for (int i = 0; i < value.Length; i++)
        //    {
        //        Console.WriteLine(value[i] = 777);
        //    }
        //}
    }
}
