using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Custom_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q, value, w;
            Console.WriteLine("Enter Size of stack");
            w = Convert.ToInt32(Console.ReadLine());
            MyStack s = new MyStack(w);
            Console.WriteLine("1.Push in stack \n2.Pop from stack \n3.Display stack \n4.exit");
            do
            {
                Console.WriteLine("\nEnter your choice");
                q = Convert.ToInt32(Console.ReadLine());

                switch (q)
                {
                    case 1:
                        try
                        {

                            Console.WriteLine("Enter value");
                            value = Convert.ToInt32(Console.ReadLine());
                            s.push(value);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            s.pop();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            s.display();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4: break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (q != 4);
        }
    }
}
