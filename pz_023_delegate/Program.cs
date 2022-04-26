using System;

delegate int MD(char a, string b);

namespace pz_023_delegate
{
    internal class Program
    {
        static int CountIn(char a, string b)
        {
            int x = 0;
            foreach (var item in b) if (item == a) x++;
            return x;
        }

        static int First(char a, string b)
        {
            for (int i = 0; i < b.Length; i++) if (b[i] == a) return i;
            return -1;
        }

        static int Main(string[] args)
        {
            char one = '0';
            string two = "1234567890";

            MD mdmd0 = new MD(CountIn);
            MD mdmd1;
            mdmd1 = First;

            Console.WriteLine("char: {0} string: {1} countIN: {2} firstIN: {3}", one, two, mdmd0(one, two), mdmd1(one, two));

            one = 'a';
            two = "zxcabcasd";

            Console.WriteLine("char: {0} string: {1} countIN: {2} firstIN: {3}", one, two, mdmd0(one, two), mdmd1(one, two));

            return 1011;
        }
    }
}
