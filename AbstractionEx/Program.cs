using System;
namespace AbstractionEx
{
    public abstract class Animal 
    {
        public abstract void MakeSound();
        public void Run()
        {
            Console.WriteLine("Animals can run");
        }
    }
    public class Dog:Animal
    { 
        public override void MakeSound()
        {
            Console.WriteLine("Bow...Bow");
        }
    }

}