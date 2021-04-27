using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class X
    {
        protected int x;
        public X()
        {
            x = 10;
        }
    }
    class Y : X
    {
        public int getX()
        {
            return x;
        }
    }
    class Program
    { 
      public  static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();
            Console.WriteLine("vale of x:" + obj2.getX());
            Console.ReadLine();
        }
    }
}
