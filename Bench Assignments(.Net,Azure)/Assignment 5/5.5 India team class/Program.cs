using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._5_India_team_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] TeamArray = new Player[3]
        {
            new Player("Sachin", "Tendulkar"),
            new Player("Virat", "Kohli"),
            new Player("Rahul", "Dravid"),
        };

            Team India = new Team(TeamArray);
            foreach (Player I in India)
                Console.WriteLine(I.firstName + " " + I.lastName);
        }
    }
}
