using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, n1 = 0;
            n1 = n = long.Parse(Console.ReadLine());
            int y;
            y = (n %2== 1) ? 1 : 2;
            //if (n % 2 == 1)
            //{
            //    y = 1;
            //}
            //else
            //{
            //    y = 2;
            //}
            while (n != y)
            {
                n -= 2;
                n1 *= n;
            }
            Console.WriteLine(n1);
        }
    }
}
