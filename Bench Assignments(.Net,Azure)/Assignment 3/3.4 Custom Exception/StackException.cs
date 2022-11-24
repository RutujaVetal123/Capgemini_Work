using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4_custom_exception
{
    public class StackException:Exception
    {
        public StackException(string message) : base(message)
        {
            
        }
    }
}
