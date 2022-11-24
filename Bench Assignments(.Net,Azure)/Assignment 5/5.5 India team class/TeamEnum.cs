using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._5_India_team_class
{
    public class TeamEnum: IEnumerator
    {
        public Player[] _Team;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public TeamEnum(Player[] list)
        {
            _Team = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _Team.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Player Current
        {
            get
            {
                try
                {
                    return _Team[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
