using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
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

                        char e;
                        Console.WriteLine("\na.Enter All At Once \nb.One At A Time");
                        e = Convert.ToChar(Console.ReadLine());
                        switch (e)
                        {
                            case 'a':
                                Console.WriteLine("\nEnter value");

                                for (int i = 0; i < w; i++)
                                {
                                    value = Convert.ToInt32(Console.ReadLine());
                                    s.push(value);
                                }
                                break;
                            case 'b':
                                Console.WriteLine("Enter value");

                                value = Convert.ToInt32(Console.ReadLine());
                                s.push(value);

                                break;
                        }
                        break;

                    case 2:
                        s.pop();
                        break;

                    case 3:
                        s.display();
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
