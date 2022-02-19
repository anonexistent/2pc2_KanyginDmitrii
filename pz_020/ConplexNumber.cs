using System;

/*
*  версия 2(текущая): _____
*  Решение pz_020 переписано с нуля
*  Game() -> Star() реализован 
*  
*/

namespace pz_020
{
    class ConplexNumber
    {
        private float a;
        public float A
        {
            get { return a; }
            set { a = value; }
        }
        private float b;
        public float B
        {
            get { return b; }
            set { b = value; }
        }
        private char i;
        public char I
        {
            get { return i = 'i'; }
        }

        private static ulong nocomplex;
        private static ulong fullcomplex;
        private static ulong total;

        public ConplexNumber(float num1, float num2)
        {
            A = num1;
            B = num2;
            total++;
            if (a != 0 & b != 0) fullcomplex++;
            if (b == 0) nocomplex++;
        }

        public ConplexNumber(float num1)
        {
            if (DateTime.Now.Ticks % 2 == 1) A = num1;
            else B = num1;
            total++;
            if (a != 0f & b != 0f) fullcomplex++;
            if (b == 0f) nocomplex++;
        }

        private static void print(object a)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        public static void About()
        {
            print(
                $"\tabout\n" +
                $"noconplex: {nocomplex}\n" +
                $"fullcomplex: {fullcomplex}\n" +
                $"{new string('—', 20)}\n" +
                $"total: {total}"
                                );
        }

        protected string CNString(float num1, float num2)
        {
            if (A == 0) return $"{B}{I}";
            if (B > 0) return $"{A}+{B}{I}";
            if (B == 0) return $"{A}";
            if (B < 0) return $"{A}-{Math.Abs(B)}{I}";
            return "";
        }

        public virtual void GetComplexNumber()
        {
            Console.WriteLine(
                $"real: {A}\n" +
                $"imaginary: {B}\n" +
                $"CN: {CNString(A, B)}\n"
                                );
        }

        public static void Star()
        {
            Console.CursorVisible = false;
            int x = 20;
            int y = 15;
            ConsoleKeyInfo k;

            Console.WriteLine("\n\nрисовать(Y/N): ");
            bool painted = Console.ReadKey().Key == ConsoleKey.Y ? true : false;
            Console.Clear();

            do
            {
                Console.SetCursorPosition(1, 1);
                Console.Write(new String(' ', 9));
                Console.SetCursorPosition(1, 1);
                Console.WriteLine($"{x}\t{y}");
                Console.SetCursorPosition(x, y);
                Console.Write('☼');
                k = Console.ReadKey(true);


                if (k.Key == ConsoleKey.W)
                {
                    if (y == 0) y = Console.WindowHeight - 1;
                    else y--;
                }
                else if (k.Key == ConsoleKey.S)
                {
                    if (y == Console.WindowHeight - 2) y = 0;
                    else y++;
                }
                else if (k.Key == ConsoleKey.A)
                {
                    if (x == 0) x = Console.WindowWidth - 2;
                    else x -= 2;
                }
                else if (k.Key == ConsoleKey.D)
                {
                    if (x == Console.WindowWidth - 2) x = 0;
                    else x += 2;
                }
                else if (k.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                }

                if (painted == false) Console.Clear();
            } while (k.Key != ConsoleKey.Escape);
        }

    }
}
