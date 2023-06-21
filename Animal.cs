using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woo!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }
    }
}
