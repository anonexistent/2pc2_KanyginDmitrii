using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 12
            int x = 0;
            Console.WriteLine("size: ");
            var N = Byte.Parse(Console.ReadLine());
            Console.WriteLine("even num: ");
            byte[] ar = new byte[N];
            byte[] ar2 = new byte[];
            Random uuu = new Random();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = (byte)uuu.Next();
                Console.WriteLine(ar[i]);
            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i != ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    ar2[i] = ar[i];
                    Console.WriteLine(ar2[i]);
                }
            }
            Console.ResetColor();
            Console.WriteLine($"amount: {ar2.Length}");
        }
    }
}
