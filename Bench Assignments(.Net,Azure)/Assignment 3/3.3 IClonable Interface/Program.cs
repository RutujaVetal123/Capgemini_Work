using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Kartik", 50000);
            e1.salarycalculation();
            Console.WriteLine(e1);

            Employee e2 = e1.Clone() as Employee;
            e2.salarycalculation();
            Console.WriteLine(e2);
        }
    }
}
