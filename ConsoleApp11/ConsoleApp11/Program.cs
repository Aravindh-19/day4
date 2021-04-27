using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class program
    {
        class student:person
        {
            public void study()
            {
                Console.WriteLine("I'm studying on the screen.");
            }
        }
        class  person
        {
            public void greet()
            {
                Console.WriteLine("Hi");
            }
            public void Setage(int age)
            {
                Console.WriteLine("Age"+age);
            }
        }
        class professor:student
        {
            public void explain()
            {
                Console.WriteLine("I'm explaining on the screen.");
            }
            public void greet()
            {
                Console.WriteLine("Hi");
            }
            public void Setage(int age)
            {
                Console.WriteLine("Age" + age);
            }
        }

        class studentprofessor
        {
            static void Main(string[] args)
            {
                person aravindh = new person();
                aravindh.greet();
                student hari = new student();
                hari.greet();
                hari.Setage(20);
                professor jd = new professor();
                jd.greet();
                jd.Setage(40);
                jd.explain();
                Console.ReadLine();


            }
        }

    }
}