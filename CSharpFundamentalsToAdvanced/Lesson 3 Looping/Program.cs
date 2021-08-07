using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Looping
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Amount");
            double amount = double.Parse(Console.ReadLine());
            double total = 0;

            while (amount !=0)
            {
                total += amount;
                Console.WriteLine("Enter next amount, or 0 to quit");
                amount = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your total is {0}", total.ToString("C"));
            //-------------------------------------------------------------------------------------------
            //double bankBal = 1000;
            //const double INT_RATE = 0.04;
            //char response;
            //do
            //{
            //    Console.WriteLine("BankBalance is {0} ", bankBal.ToString("C"));
            //    bankBal += bankBal * INT_RATE;
            //    Console.WriteLine("do you want to see next year's balance? Y or N...");
            //    response = char.Parse(Console.ReadLine());

            //} while (response=='Y' || response =='y');
            //Console.WriteLine("Have a Nice a day");

            //-------------------------------------------------------------------------------------------
            //int counter = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello {0} ", i);
            //}

            //-------------------------------------------------------------------------------------------

            //int counter = 0;
            //while (counter <10)
            //{
            //    Console.WriteLine("Hello {0} ",counter);
            //    counter++;
            //}
            //-------------------------------------------------------------------------------------------
            //double bankBal = 1000;
            //const double INT_RATE = 0.04;

            //Console.WriteLine("Do ypu want to see your balance? Y or N...");


            //char response = char.Parse(Console.ReadLine());
            //while (response == 'Y' || response == 'y')
            //{
            //    Console.WriteLine("Bank Balance is {0 }", bankBal.ToString("C"));
            //    bankBal += bankBal * INT_RATE;
            //    Console.WriteLine("Do you want to see the next year's balance Y or N...");

            //    response = char.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Have a Nice day");
            //-------------------------------------------------------------------------------------------
            //int number = 0;
            //bool myBool = true;
            //while (myBool)
            //{
            //    Console.WriteLine("Hello");
            //    myBool = false;
            //}
        }
    }
}
