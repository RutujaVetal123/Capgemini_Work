using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Custom_Exception
{
    internal class MyStack
    {
        private int[] arr;
        private int top;
        private int max;

        public MyStack(int size)
        {
            arr = new int[size];
            top = -1;
            max = size;
        }

        public void push(int value)
        {
            if (top == max - 1)
            {
                throw new StackException("\n*******Stack is Full !!!!*******");
            }
            else
            {
                arr[++top] = value;
                Console.WriteLine("+++++ Pushed Element is " + value + " +++++");
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                throw new StackException("\n*******Stack is Empty !!!!*******");
            }
            else
            {
                Console.WriteLine("----- Poped element is " + arr[top] + " -----");
                arr[top] = '\0';
                top--;
            }
        }

        public void display()
        {
            if (top > -1)
            {
                Console.WriteLine("\nStack elements are: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }
            else
            {
                throw new StackException("\n*******Stack is Empty !!!!*******");
            }
        }
    }
}
