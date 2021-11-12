using System;
using System.Linq;
using System.Collections;

namespace pz_012
{
    class Program
    {
        static void print(object a)
        {   Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(a);
            Console.ResetColor();
        }
        //static void Main(string[] args)                 //вар 1 пз 12
        //{
        //    string str = Console.ReadLine(), str0 = " ";
        //    string[] arr = str.Split(". ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (i==0 | i==arr.Length-1)
        //        {
        //            str0 = arr[0];
        //            arr[0] = arr[i];
        //            arr[i] = str0;
        //        }
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //        print(arr[i]+". ");

        //}
        static void Main(string[] args)
        {
            Console.WriteLine("text: ");

            string str = Console.ReadLine();

            string[] arr = str.Split('.');

            string a;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Length > arr[j].Length)
                    {
                        a = arr[i];

                        arr[i] = arr[j];

                        arr[j] = a;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
                print(arr[i]+' ');
        }
    }
}
