using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 12
            int j = 0;
            Console.WriteLine("size: ");
            var N = Int32.Parse(Console.ReadLine()); // размер начального массива
            int[] ar = new int[N]; //начальный массив и массив четных чисел
            int[] ar2 = new int[N];
            Random uuu = new Random();
            Console.WriteLine("array: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < ar.Length; i++) //запоняем массив
            {
                ar[i] = uuu.Next();
                Console.WriteLine(ar[i]);
            }
            Console.ResetColor();
            Console.WriteLine("even num: ");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i != ar.Length; i++) // проходим по массиву ии
            {
                if (ar[i] % 2 == 0) //и выбираем четные
                {
                    ar2[i] = ar[i];
                    Console.WriteLine(ar2[i]); //вывод%% чентные числа
                    j++; //счетчик
                }
            }
            Console.ResetColor();
            Console.WriteLine($"amount: {j}"); //вывод%% кол во четных чисел
            Console.ReadLine();
        }
    }
}
