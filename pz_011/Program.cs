using System;

namespace pz_11
{
    class Program
    {
        static void print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(a);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {

            char c = Convert.ToChar(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    Array.Resize(ref s, s.Length + 1);
                    for (int j = s.Length - 2; j >= i; j--)
                    {
                        s[j + 1] = s[j];
                    }
                    i++;
                }
            }
            for (int i = 0; i < s.Length; i++)
                print(s[i]);

        }
    }
}