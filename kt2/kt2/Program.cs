using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat263 = new Cat();
            cat263.eat();
            cat263.makeSound();
            cat263.run();
            Bird bird = new Bird();
            bird.eat();
            bird.makeSound();
            bird.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Foot");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo chay nhanh");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an ca");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo keu meo meo");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay cao");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an sau");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chim an con trung");
        }
    }
}