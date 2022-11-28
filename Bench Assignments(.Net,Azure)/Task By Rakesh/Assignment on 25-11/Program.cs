using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
           // Dog d1 = new Animal();
            Animal ani = new Dog();
            Animal ani2 = new Animal();
            d.eat();
            ani.eat();
            ani2.eat();

        }
    }
}
