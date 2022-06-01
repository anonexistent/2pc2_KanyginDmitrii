using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void str(string a)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        static void str1(string a)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Random uuu = new Random();
            char[][] myArray = new char[10][];
            char[] myArray0 = new char[10];
            int a = 0;
            char b = ' ';
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new char[uuu.Next(3, 50)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (char)uuu.Next(128);
                }
            }
            str1("array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                    Console.Write($"{myArray[i][j]} ");
                str($"\n\t\t\t—\n");
            }
            //ищем последние элементы
            for (int i = 0; i != 10; i++)
                myArray0[i] = myArray[i][^1];
            str1("last: ");
            for (int i = 0; i != 10; i++)
                Console.Write($"{myArray0[i]} ");
            str("\n");

            //ищем максимальные элементы
            for (int i = 0; i != 10; i++)
                myArray0[i] = myArray[i].Max();
            str1("max: ");

            for (int i = 0; i != 10; i++)
                Console.Write($"{myArray0[i]} ");
            str("\n");

            //вычисляем индекс и меняем местами
            for (int i = 0; i != 10; i++)
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    if (myArray[i][j] == myArray[i].Max())
                    {
                        a = Array.IndexOf(myArray[i], myArray[i][j]);
                        b = myArray[i][0];
                        myArray[i][0] = myArray[i].Max();
                        myArray[i][a] = b;
                    }
                }
            str1("new: ");

            for (int i = 0; i != 10; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                    Console.Write($"{myArray[i][j]} ");
                str($"\n\t\t\t—\n");
            }


        }
    }
}
