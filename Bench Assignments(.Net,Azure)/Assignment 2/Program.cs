using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib

{
    class Program
    {
      
        static void Main(string[] args)
        {
         
            Employee emp = new Employee();
            Console.WriteLine("*********** Employee Salary Calculater *********** ");
            Console.WriteLine("\n**************** Employee Details **************** ");
            
            Console.WriteLine("\nEnter Employee ID : ");
            emp.EmpId = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\nEnter Employee Name : ");
            emp.EmpName = Console.ReadLine();

            Console.WriteLine("\nEnter Employee Salary : ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());
            
            

            emp.CalculateSalary(emp.Salary);
        }
    }
}

/*
    //int id;
            //string name;
            //double salary;

//emp.SetEmpId(id);
            //emp.SetEmpName(name);
            //emp.SetSalary(salary);
 */