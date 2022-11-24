using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1_Basic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Copying Array to other array
            Console.WriteLine("\n---Array.Copy---\n");
            int[] IntArray1 = { 30, 40, 10,20,50 };
            int[] IntArray2 = new int[3];
            string[] StringArray1 = { "Python","C","JAVA", "CPP","C#", };
            string[] StringArray2 = new string[3];

            Console.WriteLine("Before Copy Function IntArray2 and StringArray2 are\n");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("IntArray2["+i+"] = "+IntArray2[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("StringArray2[" + i + "] = " + StringArray2[i]);
            }

            Array.Copy(IntArray1, 2, IntArray2, 0, 3);
            Array.Copy(StringArray1, 2, StringArray2, 0, 3);

            Console.WriteLine("\nAfter Copy Function IntArray2 and StringArray2 are\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("IntArray2[" + i + "] = " + IntArray2[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("StringArray2[" + i + "] = " + StringArray2[i]);
            }
            Console.WriteLine("\n************************************\n");

            //Sorting of Array
            Console.WriteLine("---Array.sort---\n");

            Console.WriteLine("Before sort Function IntArray1 and StringArray1 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }

            Array.Sort(IntArray1);
            Array.Sort(StringArray1);

            Console.WriteLine("\nAfter Sort Function IntArray1 and StringArray1 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }
            Console.WriteLine("\n************************************\n");

            //Reverse of Array
            Console.WriteLine("---Array.reverse---\n");

            Console.WriteLine("Before Reverse Function IntArray1 and StringArray1 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }

            Array.Reverse(IntArray1);
            Array.Reverse(StringArray1);

            Console.WriteLine("\nAfter Reverse Function IntArray1 and StringArray1 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }
            Console.WriteLine("\n************************************\n");

            //Clearing Array Elements

            Console.WriteLine("---Array.clear---\n");

            Console.WriteLine("Before Clear Function IntArray1 and StringArray1 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }

            Array.Clear(IntArray1,2,2);
            Array.Clear(StringArray1,2,2);

            Console.WriteLine("\nAfter Clear Function IntArray2 and StringArray2 are\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("IntArray1[" + i + "] = " + IntArray1[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("StringArray1[" + i + "] = " + StringArray1[i]);
            }
            Console.WriteLine("\n************************************\n");
        }
    }
}
