using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._5_India_team_class
{
    public class Team : IEnumerable
    {
        private Player[] _Team;
        public Team(Player[] pArray)
        {
            _Team = new Player[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _Team[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(_Team);
        }
    }
}
