using System;
using System.Text.RegularExpressions;
using System.IO;

/* README
    в данном уроке вы научимся работать с регулярными выражениями, паралельно закрепим знания по следущим темам:
    1 строки
    2 массивы
    3 цыиклы
    4 методы 
    структура этого занятия имеет следующий вид имеется 4 упражнения рписанные в классе Exercises. 
    решение каждого упражнение находится в отдельных методах.
*/

namespace pz_019_regular_expression
{
    class Exercises
    {
        public string Ex1 = "Создайте регулярное выражение, которое бы удалял из текста слова tel  и\n" +
            "fax (если после данных слов стоят двоеточия, то их тоже следует удалить).";
        public string Ex10 = "Создайте регулярное выражение, которое бы меняло шестизначные номера\n" +
            "на семизначные добавлением 0 после первых двух цифр. Например, номер 12-34-56 заменился бы на 120-34-56.";
        public string Ex2 = "Запишите регулярное выражение, соответствующее:\n" +
            "1. дате в формате дд.мм.гг или дд.мм.гггг\n" +
            "2. времени в формате чч.мм или чч:мм\n" +
            "3. целому числу (со знаком и без)\n" +
            "4. вещественному числу(со знаком и без, с дробной частью и без, с целой частью и без)\n" +
            "Примените шаблоны к произвольному тексту и запишите коллекцию результатов в текстовый файл\n";
        public string Ex3 = "Создайте на диске текстовый файл connects.log с содержимым представленным ниже.\n" +
            "С помощью регулярных выражений произведите анализ и выведите следующую информацию:\n" +
            "IP адреса подключений\n" +
            "Даты подключений";
    }

    class Program
    {
        //чтобы мы могли выполнить некоторые моменты мы так сказать реализуем а точнее инициализируем сразу в классе Program 

        static Exercises exs = new Exercises();

        static Random uuu = new Random();

        //самое простое в нашем сегоднешнем уроке - метод реализующий цветной текст в консоли дабы отделить особо важные символы от неособоважных

        static void Print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        //уже потруднее но все такой же легкий метод реализующий цветной текст в консоли дабы отделить особо важные символы от неособоважных

        static void PrintExercises(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        //и вот началось... упражнение 1 

        static void Exercise1()
        {
            PrintExercises(exs.Ex1);
            string text1 =
                $"Контакты в Москве tel: {uuu.Next(111111, 999999).ToString("##-##-##")}; fax: {uuu.Next(111111, 999999).ToString("##-##-##")}\n" +
                $"Контакты в Саратове tel {uuu.Next(111111, 999999).ToString("##-##-##")}; fax {uuu.Next(111111, 999999).ToString("##-##-##")}";
            Console.WriteLine("old data:\n" + text1);
            string newText1 = Regex.Replace(text1, "tel:*|fax:*", "");
            Console.WriteLine("new data:\n" + newText1);

            Console.ReadKey();
            Console.Clear();
        }

        //другое упражнение 1. 

        static void Exercise10()
        {
            PrintExercises(exs.Ex10);
            string text2 =
                $"Контакты в Москве tel: {uuu.Next(111111, 999999).ToString("##-##-##")}; fax: {uuu.Next(111111, 999999).ToString("##-##-##")}\n" +
                $"Контакты в Саратове tel {uuu.Next(111111, 999999).ToString("##-##-##")}; fax {uuu.Next(111111, 999999).ToString("##-##-##")}";
            Console.WriteLine("old data:\n"+text2);
            Regex inq = new Regex(@"\d\d(-\d\d){2}");
            MatchCollection rrr = inq.Matches(text2);
            Console.WriteLine("new data:");
            foreach (Match item in rrr)
            {
                Console.WriteLine(Regex.Replace(item.ToString(), item.ToString().Substring(0, 2), item.ToString().Substring(0, 2) + "0"));
            }
            Console.ReadKey();
            Console.Clear();
        }

        /*упражнение 2. анализируем файл а точнее ищем классы данных, указанные в задании.
        все так же просто и никаких сложностей не должно возникнуть. наверное*/

        static void Exercise2()
        {
            PrintExercises(exs.Ex2);
            int i = 0;
            string file = @"C:\fet\1512.txt";
            string[] f1lstrs = File.ReadAllLines(file);
            Regex regdate = new Regex(@"\d\d\.\d\d\.\d\d");
            Regex regtime = new Regex(@"\d\d\:\d\d");
            Regex regdouble = new Regex(@"\d,\d+");
            string filestrs = string.Join(' ', f1lstrs);
            MatchCollection resdate = regdate.Matches(filestrs);
            MatchCollection restime = regtime.Matches(filestrs);
            MatchCollection resdouble = regdouble.Matches(filestrs);
            foreach (var item in resdate) i++;
            Console.WriteLine("amount of date: " + i);
            i = 0;
            foreach (var item in restime) i++;
            Console.WriteLine("amount of time: " + i);
            i = 0;
            foreach (var item in resdouble) i++;
            Console.WriteLine("amount of REAL numder: " + i);
            Console.ReadKey();
            Console.Clear();
        }

        /*упражнение 3. мы опять работаем с файлом но тут уже попроще*/

        static void Exercise3()
        {
            PrintExercises(exs.Ex3);
            int i = 0;
            string file = @"C:\fet\fakelgs.txt";
            string[] f1lstrs = File.ReadAllLines(file);
            Regex regip = new Regex(@"\d{2,3}(.\d{2,3}){3}");
            Regex regtime = new Regex(@"\d\d \/ \w\w\w \/ \d{4} \d\d:\d\d \+ 0000");
            string filestrs = string.Join(' ', f1lstrs);
            MatchCollection resip = regip.Matches(filestrs);
            MatchCollection restime = regtime.Matches(filestrs);
            foreach (var item in resip) i++;
            Console.WriteLine("amount of ip: " + i);
            i = 0;
            foreach (var item in restime) i++;
            Console.WriteLine("amount of time: " + i);
            Console.ReadKey();
            Console.Clear();
        }

        //самый главны момент нашего сегоднешнего урока только ради него было созданно данное видео. приятного просмотра

        static void TheEnd(string text)
        {
            int width = Console.WindowWidth;
            if (text.Length < width)
            {
                text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');
            }
            Print("\n\n\n\n\n\n\n\n\n\n\n\n"+text+ "\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }

        static void Main(string[] args)
        {

            Exercise1();
            Exercise10();
            Exercise2();
            Exercise3();
            TheEnd("the end thank you for your attention. have a good day");
        }
    }
}
