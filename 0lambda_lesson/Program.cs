using System;

delegate char MD();

namespace _0lambda_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoService obj1 = new AutoService("qwerty", true);
            Console.WriteLine($"{obj1.meth()}");
            AutoService obj10 = new AutoService("qwerty", false);
            Console.WriteLine($"{obj10.meth()}");

            AutoService obj2 = new AutoService("RUSSIA!!!", false);
            Console.WriteLine($"{obj2.meth()}");
            AutoService obj20 = new AutoService("RUSSIA!!!", true);
            Console.WriteLine($"{obj20.meth()}");
        }
    }
}
