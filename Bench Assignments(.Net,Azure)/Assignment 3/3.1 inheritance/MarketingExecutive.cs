using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    internal class MarketingExecutive:Employee
    {
        private double KmTravelled;
        private double TourAllowance;
        private double TelephoneAllowance;
        public MarketingExecutive() : base()
        {
            KmTravelled = 00;
            TourAllowance = 00;
            TelephoneAllowance = 00;
        }
        public MarketingExecutive(string Name, double BasicSalary, double KmTravelled) : base(Name, BasicSalary)
        {
            this.KmTravelled = KmTravelled;
            this.TourAllowance = 5 * KmTravelled;
            this.TelephoneAllowance = 1000;
        }

        public override void salarycalculation()
        {

            Pf = BasicSalary * 0.10;
            GrossSalary = BasicSalary + TourAllowance + TelephoneAllowance;
            NetSalary = GrossSalary - Pf;
        }

        public void Display()
        {
            Console.WriteLine("\n\nEmplyee Id : " + Id + "\nEmployee Name : " + Name +
                "\nGrossSalary : " + GrossSalary + "\nNetSalary : " + NetSalary);
        }
        
    }
}
