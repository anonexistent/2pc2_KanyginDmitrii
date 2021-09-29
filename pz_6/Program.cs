using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n, n1 = 0;
            n1 = n = ulong.Parse(Console.ReadLine());
            int y;
            y = 
            if (n % 2 == 1)
            {
                y = 1;
            }
            else
            {
                y = 2;
            }
            while (n != y)
            {
                n -= 2;
                n1 *= n;
            }
            Console.WriteLine(n1);
        }
    }
}
