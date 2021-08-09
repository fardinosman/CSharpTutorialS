using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);

      
            r.Length = 4;
            r.Width = 5;



            //Employee[] arrEmployee = new Employee[2];
            //arrEmployee[0] = new Employee(10, "Fardoin");
            //arrEmployee[1] = new Employee(11, "fin");

            //for (int i = 0; i < arrEmployee.Length; i++)
            //{
            //    arrEmployee[i].WelcomeMessage();
            //}
            //Employee e1 = new Employee(15);
            //e1.setMoney(600);
            //Console.WriteLine(e1.Money);


            //e1.Spend(400);
            //Console.WriteLine(e1.Money);

            //Employee e3 = new Employee(4, "Cali");
            //e3.WelcomeMessage();

            //Employee emp1 = new Employee(10);
            //Employee emp2 = new Employee(20);
            //Employee emp3 = emp1 + emp2;

            //emp3.WelcomeMessage();
            //e1.WelcomeMessage();
            //e1.ChangePassword("string");
            //Console.WriteLine(e1.Password);


            //Employee e2 = new Employee(10);
            //e2.WelcomeMessage();


            //TakeIn(e1);
        }
        private static void TakeIn(Employee emp)
        {
            emp.WelcomeMessage();
        }
    }
}
