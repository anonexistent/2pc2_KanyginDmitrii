using System;

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

        static void Main(string[] args)
        {
            Random uuu = new Random();
            char[][] myArray = new char[10][];
            char[] myArray0 = new char[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new char[uuu.Next(3,50)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (char)uuu.Next(128);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"{myArray[i][j]} ") ;
                }
                str($"\n—\n");
            }
            for (int i = 0; i !=10 ; i++)
                myArray0[i] = myArray[i][^1];
            str("last symbols: ");
            for (int i = 0; i !=10 ; i++)
                Console.Write($"{myArray0[i]} ");
            str("");



        }
    }
}
