using System;

namespace pz_016
{
    class Program
    {
        /*  Дано целое число K и текстовый файл. Удалить из файла строку с номером K. Если строки с
            таким номером нет, то оставить файл без изменений.  */
        static ulong Fak(ulong a)
        {
            if (a == 0) return 0;
            ulong result = 1;
            for (ulong i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            ulong result = 0;
            ulong inputnumber = ulong.Parse(Console.ReadLine());
            for (ulong i = 0; i <= inputnumber; i++)
            {
                result += Fak(i);
            }
            Console.WriteLine(result);
        }
    }
}
