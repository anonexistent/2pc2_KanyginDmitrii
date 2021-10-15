using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            int x, y, z;
            x = y = z = 0;                              
            sbyte[,] ar = new sbyte[8, 6];
            sbyte[] ar0 = new sbyte[48];
            Random uuu = new Random();
            //пробегаемся  по массиву ar: выводим его, добавляем элементы в доп массив,
            //чтоб потом сложить(y) и находи минимальный элемент массива(z)
                for (int i=0; i != 8; i++) 
                {        
                
                for(int j=0; j!=6;j++)
                {
                    ar[i, j] = (sbyte)uuu.Next(sbyte.MinValue, sbyte.MaxValue);
                    Console.Write($"{ar[i, j]} \t");
                    if (ar[i, j] > 0)
                    {
                        ar0[x] = ar[i, j];
                        x++;
                    }
                    else if (ar[i, j] < z)
                    {
                        z = ar[i,j];            
                    }                  
                }
                Console.WriteLine();
                }
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            //у - сумма "+элементов"
            while (x!=0)                
            {
                y += ar0[x];
                x--;
            }
            Console.WriteLine($"Ответ: {y*z}");

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
