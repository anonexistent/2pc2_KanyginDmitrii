using System;

namespace pz_018
{
    class Program
    {
        static int Ex1(int n)
        {
            int a1 = -95;
            if (n > 0) return a1 += 5 * (n - 1);
            return Ex1(n);
        }

        static decimal Ex2(decimal n)
        {
            decimal num = 12;
            if (n == 1) return num;
            else if (n == 2) return num * 0.01m;
            return 0.01m * Ex2(n - 1);
        }

        /*внимание!!! не баг а фича*/
        static int Ex3(int a, int b)
        {
            if (a == b) return a;
            if (a < b) { Console.WriteLine(a); return Ex3(a + 1, b); }
            if (a > b) { Console.WriteLine(b); return Ex3(a, b + 1);}
            return 0;
        }

        public static void Main()
        {
            Console.WriteLine(Ex1(3));

            Console.WriteLine(Ex2(3));

            int q = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine(Ex3(q, w));
        }
    }
}
