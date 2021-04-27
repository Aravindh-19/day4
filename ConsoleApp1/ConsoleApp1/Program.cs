using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class1;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            class1 class1 = new class1();
            Console.WriteLine(class1.Sum(1, 2));
            Console.WriteLine(class1.sub(1, 2));
            Console.WriteLine(class1.product(1, 2));
            Console.WriteLine(class1.div(2, 2));
            Console.ReadLine();
        }
    }
}
