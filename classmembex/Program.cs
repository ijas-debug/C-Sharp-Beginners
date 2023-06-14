using System;

namespace OOPsex
{
    public class Fruit
    {
        public string color; //field:variables inside the class
        public string name;

        public void DisplayName() //objectmethod
        {
            Console.WriteLine(name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit();
            apple.color = "red";
            apple.name = "Apple";
            apple.DisplayName();

            Console.WriteLine(apple.color);
        }
    }
}
