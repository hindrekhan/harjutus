using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektid
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();

            dog1.NumberOfEyes = 3;
            Console.WriteLine(dog1.Name);
            Console.WriteLine(dog1.RealYears);
            Console.WriteLine(dog1.Color);
            dog1.Bark();
            Console.WriteLine("Koera tegelik vanus: " + dog1.CalculateDogYears());


        }
    }
}
