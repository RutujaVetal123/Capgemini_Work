using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("Kartik", 50000);
            e1.salarycalculation();

            Employee e2 = new Employee("Ganesh", 50000);
            e2.salarycalculation();

            Employee e3 = new Employee("Ganesh", 50000);
            e2.salarycalculation();

            List<Employee> employees = new List<Employee>();

            /********** Add to list **********/
            employees.Add(e1);
            employees.Add(e2);

            /********** Print list **********/
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(((Employee)employees[i]).DisplayEmployeeList());
            }

            /********** Find in list **********/
            Console.WriteLine("\nNumber of employee present in list are = "+employees.Count);

            Console.WriteLine("\nEnter the name of employee you want to find");

            string temp=Console.ReadLine();
            int count = 0;

            for(int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Name.Equals(temp))
                {
                    Console.WriteLine("\nFound your search");
                    Console.WriteLine(employees[i].DisplayEmployeeList());
                    count = 1;
                }   
                
            }
            if (count==0)
            {
                Console.WriteLine("No search results found");
            }

                
        }
    }
}
