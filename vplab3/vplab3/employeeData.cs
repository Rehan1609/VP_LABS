using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace vplab3
{
    class employeeData
    {
        public void Welcome()
        {
            Console.WriteLine("\n\n\t\t\t\t\t________________________________");
            Console.WriteLine("\t\t\t\t\t|Welcome to BU Salary Estimator|");
            Console.WriteLine("\t\t\t\t\t________________________________");
        }
        public void choices()
        {
            Console.WriteLine("\n\t\t\t\t\t__________________________________");
            Console.WriteLine("\t\t\t\t\t|Press                           |");
            Console.WriteLine("\t\t\t\t\t|1. To check your weekly salary  |");
            Console.WriteLine("\t\t\t\t\t|2. To check your monthly salary |");
            Console.WriteLine("\t\t\t\t\t|3. To check your yearly salary  |");
            Console.WriteLine("\t\t\t\t\t__________________________________");
        }
        public double Weekly(double amount)
        {
            return amount * 7;
        }
        public double monthly(double amount)
        {
            return amount * 30.42;
        }
        public double yearly(double amount)
        {
            return amount * 365;
        }
        public void getData(string name, double salary)
        {
            Welcome();
            int choice = 0;
            Console.Write("\n\n\t\t\t\tEnter your name : ");
            name = Console.ReadLine();
            Console.Write("\n\n\t\t\t\tEnter per day salary : ");
            salary = double.Parse(Console.ReadLine());
            choices();
            Console.Write("\n\t\t\t\tEnter your choice : ");
            choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\t\tAmount data saved! Don't worry. :-)");
                choices();
                Console.Write("\nEnter your choice : ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                Console.WriteLine("\n\n\t\t\t\tYour weekly salary is : " + (Weekly(salary)) + " Rs");
            }
            if (choice == 2)
            {
                Console.WriteLine("\n\t\t\t\tYour weekly salary is : " + (monthly(salary)) + " Rs");
            }
            if (choice == 3)
            {
                Console.WriteLine("\n\t\t\t\tYour weekly salary is : " + (yearly(salary)) + " Rs");
            }

        }
    }
}