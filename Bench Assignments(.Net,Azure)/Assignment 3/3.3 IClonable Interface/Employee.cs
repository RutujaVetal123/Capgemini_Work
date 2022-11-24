using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    internal class Employee:ICloneable
    {
        protected static int count;
        protected int Id;
        protected string Name;
        protected double Hra, Da, Pf, GrossSalary, BasicSalary,NetSalary;
        public Employee()
        {
            count++;
            Id = count;
            Name = "unknown";
            BasicSalary = 00;
        }

        public Employee(string Name, double BasicSalary)
        {
            count++;
            this.Id = count;
            this.Name = Name;
            this.BasicSalary = BasicSalary;
        }
        public virtual void salarycalculation()
        {
            Hra = BasicSalary * 0.40;
            Da = BasicSalary * 0.20;
            Pf = BasicSalary * 0.10;
            GrossSalary = BasicSalary + Hra + Da;
            NetSalary=BasicSalary-Pf;
        }

        public object Clone()
        {
            return new Employee(this.Name, this.BasicSalary);
        }
        public override string ToString()
        {
            return "Netsalary of " + Name + ", employee Id = " + Id + " is " + NetSalary;
        }
    }
}
