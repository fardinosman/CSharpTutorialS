using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Classes
{
    class Employee
    {

        public string Name { get; set; }
        public double Money { get; set; } = 500;
        private string password = "password123";
        public int ID { get; set; }

        public static int year = 33;
        public static Employee operator+(Employee e1, Employee e2)
        {
            Employee newEmployee = new Employee(e1.ID + e2.ID);
            return newEmployee;
        }
        public Employee( int id  , string name)
        {
            ID = id;
            Name = name;

        }

        public Employee()
        {
            ID = 1;
            Name = "Cal";
        }
        public Employee(int id)
        {
            ID = id;
            Name = "Cal";
        }
        public static void Play()
        {
            Console.WriteLine("Play Method");
        }

        public void Spend(double value)
        {
            Money -= value;
            Console.WriteLine("Current balance: {0}", Money);
        }
        public double getMoney()
        {
            return Money;
        }
        public void setMoney(double amount)
        {
            if (amount > 0)
            {
                Money += amount;
                if (Money < 0)
                {
                    Money = 0;
                }
            }
            else
            {
                Console.WriteLine("Enter positive number");
            }
           
            
        }

        public string Password
        {
            get
            {
                if (idNumber >= 10)
                {
                    return password;
                }
                else
                {
                    Alert();
                    return "you can see the password";
                }
            }
            set
            {
                if (idNumber >= 10)
                {
                    password = value;
                }
            } 
        }
        public void Alert()
        {
            Console.WriteLine("person trying to hack password");
        }

        public void ChangePassword(string change)
        {
            if (idNumber >= 10)
            {
                password = change;
            }
        }

        private int idNumber;

       
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome fro Employee #{0} name {1}", ID, Name);
            Console.WriteLine("How can i help you");
        }
    }
}
