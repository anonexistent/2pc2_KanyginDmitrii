using System;
using System.Collections.Generic;
using System.Text;

namespace pz_020
{
    class ConplexNumber
    {
        private float a;
        private const char i = 'i';
        private float b;
        private ulong amount;
        //private string negative_positive = $"{(a<0?"-":"+")}{}";

        public ConplexNumber(float A, float B) {a=A; b=B; amount++; }
        public ConplexNumber() { amount++; }

        public static void GetConplexNumber(ConplexNumber qq)
        {
            
            if (qq.a != 0 & qq.b != 0)
                Console.WriteLine($"ConplexNumber: {qq.a}{(qq.b>0?'+':'-')}{Math.Abs(qq.b)}{i}");
            else if (qq.a == 0 & qq.b != 0) Console.WriteLine($"ConplexNumber: {qq.b}{i}");
            else if (qq.b == 0) Console.WriteLine($"Number: {qq.a}");
        }

        
        public override string ToString()
        {
            return $"{a}{(b > 0 ? '+' : '-')}{Math.Abs(b)}{i}";
        }

        public void GetInfo()
        {
            Console.WriteLine(
                $"numbers of conn numbers: {amount}\n"
                //+
                //$"\tof them {negative_positive} un_conplex"
                );
        }

        //public static void Game()
        //{
        //    Console.CursorVisible = false;
        //    int x = 20;
        //    int y = 15;
        //    ConsoleKeyInfo k;

        //    Console.WriteLine("рисовать(Y/N): ");
        //    bool painted = Console.ReadKey().Key == ConsoleKey.Y ? true : false;
        //    Console.Clear();

        //    do
        //    {                
        //        Console.SetCursorPosition(1, 1);
        //        Console.WriteLine($"{x}\t{y}");
        //        Console.SetCursorPosition(x, y);
        //        Console.Write((char)3);
        //        k = Console.ReadKey(true);

        //        if (k.Key == ConsoleKey.W)
        //            y--;
        //        else if (k.Key == ConsoleKey.S)
        //            y++;
        //        else if (k.Key == ConsoleKey.A)
        //            x--;
        //        else if (k.Key == ConsoleKey.D)
        //            x++;

        //        if (painted == false) Console.Clear();
        //    } while (k.Key != ConsoleKey.Escape);
        //}
    }
}
