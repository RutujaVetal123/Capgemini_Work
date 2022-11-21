using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    public class InvalidSalaryException : Exception
    {
        public InvalidSalaryException(string message) : base(message)
        {
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }


        public double NetSalary;
        public double GrossSalary;






        public void CalculateSalary(double salary)
        {
            try
            {
                if (salary > 0) { 
                    if (salary < 5000)
                    {
                        HRA = 0.1 * salary;
                        TA = 0.05 * salary;
                        DA = 0.15 * salary;
                    }
                    else if (Salary >= 5000 && Salary < 10000)
                    {
                        HRA = 0.15 * salary;
                        TA = 0.1 * salary;
                        DA = 0.2 * salary;
                    }

                    else if (salary >= 10000 && salary < 15000)
                    {
                        HRA = 0.2 * salary;
                        TA = 0.15 * salary;
                        DA = 0.25 * salary;
                    }
                    else if (salary >= 15000 && salary < 20000)
                    {
                        HRA = 0.25 * salary;
                        TA = 0.2 * salary;
                        DA = 0.3 * salary;
                    }

                    else if (salary >= 20000)
                    {
                        HRA = 0.15 * salary;
                        TA = 0.1 * salary;
                        DA = 0.2 * salary;
                    }

                GrossSalary = salary + HRA + TA + DA;
                PF = GrossSalary * 0.1;
                TDS = GrossSalary * 0.18;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("\n GrossSalary : " + GrossSalary + "\n NetSalary : " + NetSalary);
            }
            else
            {
                throw (new InvalidSalaryException("Salary should be non zero and positive"));
            }
        }
            catch (InvalidSalaryException e)
            {
                Console.WriteLine("InvalidSalaryException: {0}", e.Message);
            }
        
        }
    }

    
}


/*
 
        //public Employee() { }
        //// Get and Set for employee Id

        //public int GetEmpId() {
        //    return EmpId;
        //}
        //public void SetEmpId(int id) {
        //    this.EmpId = id;
        //}

        //// Get and Set for employee name
        //public string GetEmpName()
        //{
        //    return EmpName;
        //}
        //public void SetEmpName(string name) {
        //    this.EmpName = name;
        //}

        //// Get and Set for Salary
        //public double GetSalary()
        //{
        //    return Salary;
        //}
        //public void SetSalary(double salary) {
        //    this.Salary = salary;
        //}
 
 */