using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1!!!
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("exercise 1");
            Console.WriteLine();
            Console.ResetColor();
            for (var i =-100; i<50; i+=5)
            {
                Console.WriteLine(i + 5);
            }

            // задание 2
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("exercise 2");
            Console.WriteLine();
            Console.ResetColor();
            char s111 = 'M';
            for (var i =0; i<5; i++)
            {
                Console.WriteLine(s111);
                s111++;
            }

            // задание 3
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("exercise 3");
            Console.WriteLine();
            Console.ResetColor();
            var j1 = '#';
            for (int i = 0; i != 4; i++) 
            {
                for(int i0 = 0; i0!=6; i0++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine();
            }

            // задание 4
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("exercise 4");
            Console.WriteLine();
            Console.ResetColor();
            for (int i = 1; i!=100; i++)
            {
                var cc = i % 7;
                if(cc==0 )
                {
                    Console.WriteLine(i);
                }
            }

            // задание 5
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("exercise 5");
            Console.WriteLine();
            Console.ResetColor();
            int j = 40;
            for(int i=1;i<j+10; i++)
            {
                Console.WriteLine(i + " " + j);
                j--;
            }
        }
    }
}
