using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._2_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Kartik", 50000);
            e1.salarycalculation();
           
            Employee e2 = new Employee("Ganesh", 50000);
            e2.salarycalculation();

            ArrayList employees = new ArrayList();

            employees.Add(e1);
            employees.Add(e2);

            Console.WriteLine("By calling function\n");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(((Employee)employees[i]).Display());
            }

            Console.WriteLine("\nBy calling object\n");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
