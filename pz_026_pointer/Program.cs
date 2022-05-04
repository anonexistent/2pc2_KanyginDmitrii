using System;

/*12. Напишите программу, в которой через указатель реализуется подсчет количества спецсимволов в строке, 
введенной пользователем.
*/

namespace pz_026_pointer
{
    //???????      http://www.unicode.org/charts/PDF/UFFF0.pdf     ???????
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = 0;

            unsafe
            {
                fixed (char* x = a) for (int i = 0; i < a.Length; i++) if (!Char.IsLetter(x[i]) && !Char.IsDigit(x[i])) b++;
            }

            Console.WriteLine(b);
        }
    }
}