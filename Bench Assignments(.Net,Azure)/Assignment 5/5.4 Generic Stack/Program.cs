using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._4_generic_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q;
            
            Stack MyStack = new Stack();
            Console.WriteLine("1.Push in stack \n2.Pop from stack \n3.Display stack \n4.exit");
            do
            {
                Console.WriteLine("\nEnter your choice");
                q = Convert.ToInt32(Console.ReadLine());

                switch (q)
                {
                    case 1:
                                                                                                                     
                        Console.WriteLine("Enter value");
                        MyStack.Push(Convert.ToInt32(Console.ReadLine()));

                        break;
                       

                    case 2:
                        MyStack.Pop();
                        break;

                    case 3:
                        foreach(var element in MyStack)
                        {
                            Console.WriteLine(element);
                        }
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (q != 4);
        }
    }
}
