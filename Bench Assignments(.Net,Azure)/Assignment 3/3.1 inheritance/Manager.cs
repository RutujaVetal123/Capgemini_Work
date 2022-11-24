using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    internal class Manager:Employee
    {
        private double FoodAllowance;
        private double PetrolAllowance;
        private double OtherAllowance;
        public Manager() : base()
        {
            FoodAllowance = 00;
            PetrolAllowance = 00;
            OtherAllowance = 00;
        }
        public Manager(string Name, double BasicSalary) : base(Name, BasicSalary)
        {
            this.FoodAllowance = 0.08*BasicSalary;
            this.PetrolAllowance = 0.13 * BasicSalary;
            this.OtherAllowance = 0.03 * BasicSalary;
        }

        public override void salarycalculation()
        {
            
            Pf = BasicSalary * 0.10;
            GrossSalary = BasicSalary + FoodAllowance + PetrolAllowance + OtherAllowance;
            NetSalary = GrossSalary - Pf;
        }

        public void Display()
        {
            Console.WriteLine("\n\nEmplyee Id : " + Id + "\nEmployee Name : " + Name +
                "\nGrossSalary : " + GrossSalary + "\nNetSalary : " + NetSalary);
        }
        
    }
}
