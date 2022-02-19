using System;

namespace pz_020
{
    internal class Program
    {
        private static bool Ddouble()
        {
            bool yes = false;
            if (Console.ReadKey().Key == ConsoleKey.Q && Console.ReadKey().Key == ConsoleKey.W) yes = true;
            return yes;
        }

        static void Main(string[] args)
        {
            float a = -2.9f;
            float b = 5.76f;
            ConplexNumber q = new ConplexNumber(a, b);
            q.GetComplexNumber();

            a = 3f;
            ConplexNumber w = new ConplexNumber(a);
            w.GetComplexNumber();

            a = 10f;
            b = -0.2f;
            ConplexNumber e = new ConplexNumber(a, b);
            e.GetComplexNumber();

            a = 7.93f;
            b = 0.16f;
            ConplexNumber r = new ConplexNumber(a, b);
            r.GetComplexNumber();

            b = 0;
            ConplexNumber t = new ConplexNumber(a, b);
            t.GetComplexNumber();


            a = 5.1f;
            b = -0.99f;
            NegativeCN z = new NegativeCN(a, b);
            z.GetComplexNumber();

            a = -10.10f;
            b = 4.3f;
            NegativeCN x = new NegativeCN(a, b);
            x.GetComplexNumber();

            ConplexNumber.About();

            if (Ddouble()) ConplexNumber.Star();
        }
    }
}
