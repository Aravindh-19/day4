using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y;
            try
            {
                y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
