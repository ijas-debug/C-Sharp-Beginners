using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog animal =new Dog();
            animal.MakeSound();
            animal.Run();   
        }
    }
}
