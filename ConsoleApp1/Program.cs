using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // объявление рандома
            double[][] myArray = new double[10][]; // зуб. массив
            double[] myArray0 = new double[10];// второй массив
            double[] maxItemsArray = new double[10]; // для макс. значений
            int a = 0;
            double b = 0;


            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new double[rnd.Next(3, 30)]; // присв. диапазона
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (double)rnd.Next(1024);

                }

            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " "); // вывод массива со случ. числами

                }
                Console.WriteLine();

            }
            for (int i = 0; i != 10; i++)
                myArray0[i] = myArray[i][^1];
            Console.WriteLine("Последние элементы: ");
            for (int i = 0; i != 10; i++)
                Console.Write($"{myArray0[i]}; "); // вывод последних элементов
            Console.WriteLine();

            Console.WriteLine("Максимальные элементы:");
            for (int i = 0; i < 10; i++)
            {
                maxItemsArray[i] = myArray[i].Max(); // присв. макс. знач. в массив

            }
            foreach (var i in maxItemsArray)
            {
                Console.Write(i + " "); // вывод макс. элементов

            }
            Console.WriteLine();

            Console.WriteLine("Обновленный массив:");

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
            for (int i = 0; i != 10; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"{myArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
