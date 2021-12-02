using System;

namespace pz_018
{
    //class Exercises
    //{
    //    public string Ex1 = "С помощью рекурсии вычислите n-й член арифметической прогрессии, значения первого элемента a1 и шаг d в табл. 1.\n вариант 12 а1=-95 d=5 \n";
    //    public string Ex2 = "С помощью рекурсии вычислить n-й член геометрической прогрессии, значения первого элемента b1 и знаменатель\n прогрессии q в табл. 2.\n вариант b1=12 12 q=0,01 \n";
    //    public string Ex3 = "Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B включительно, используя рекурсию,\n в порядке возрастания, если A<B, или в порядке убывания в противном случае.\n вариант 12*1\n";
    //    public string Ex4 = "Задания на 5: 1 С помощью рекурсии Summ(int x) для введенного числа n вычислить сумму чисел от 1 до n\nНапример: Summ(2) = 2+1 = 3\n";
    //    public string Ex5 = "2 С помощью рекурсии Power(int a, int n) найдите степень числа Например: Power(2,3) *= Power(2,2) *= … *= Power(2,0)\n";
    //    public string Ex6 = "3 Описать рекурсивную функцию Palindrom(S) логического типа, возвращающую True, если строка S является палиндромом\n(то есть читается одинаково слева направо и справа налево), и False в противном случае.Оператор цикла в теле функции\n не использовать. Вывести значения функции Palindrom для пяти данных строк.\n";

    //}

    class Program
    {
        static int Ex1(int n)
        {
            int a1 = -95;
            if (n > 0) return a1 += 5 * (n - 1);
            return Ex1(n);
        }

        static decimal Ex2(decimal n)
        {
            decimal num = 12;
            if (n == 1) return num;
            else if (n == 2) return num * 0.01m;
            return 0.01m * Ex2(n - 1);
        }

        /* *1 внимание!!! не баг а фича*/
        static int Ex3(int a, int b)
        {
            if (a == b) return a;
            if (a < b) { Console.WriteLine(a); return Ex3(a + 1, b); }
            if (a > b) { Console.WriteLine(b); return Ex3(a, b + 1);}
            return 0;
        }

        static int Ex51Sum(int a)
        {
            if (a == 0) return 0;
            if (a== 1) return 1;
            return Ex51Sum(a - 1)+a;
        }

        static int Ex52Pow(int a, int b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;
            return Ex52Pow(a, b - 1) * a;
        }

        static bool Ex53Palindrom(string a)
        {
            if (a[0] == a[^1] & a.Length == 3 | a.Length==2) return true;
            if (a[0] == a[^1]) return Ex53Palindrom(a.Substring(1, a.Length - 2));
            else return false;
            return Ex53Palindrom(a.Substring(1, a.Length -2));
        }

        public static void Main()
        {
            Exercises o = new Exercises();

            Console.WriteLine(o.Ex1 +"\n"+ Ex1(3));

            Console.WriteLine(o.Ex2 + "\n" + Ex2(3));

            Console.WriteLine(o.Ex3);
            int q = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine(Ex3(q, w));

            Console.WriteLine(o.Ex4 +"\n" + Ex51Sum(6));

            Console.WriteLine(o.Ex5 + "\n" + Ex52Pow(2,6));

            Console.WriteLine(o.Ex6 + "\n" + Ex53Palindrom("шалаш"));
        }
    }
}
