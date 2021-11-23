using System;
using System.IO;

namespace pz_014
{
    class Program
    {
        static void print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(a);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            FileInfo[] aboutfouler = new DirectoryInfo(@"C:\fet\").GetFiles();

            print("pls choose .txt file pls (number):");

            for (int i = 0; i < aboutfouler.Length; i++) Console.Write($"\t{i}) " + aboutfouler[i].ToString().Substring(7) + "\n");

            int filenumber = 0;

            do
            {
                filenumber = int.Parse(Console.ReadLine());
            } while (aboutfouler[filenumber].Extension != ".txt");

            if (aboutfouler[filenumber].Extension != ".txt") Console.WriteLine("mb u can to choose another file?");
            else
            {
                FileStream file1 = new FileStream(new string($"{aboutfouler[filenumber]}"), FileMode.Append);

                print("what to add to file");

                char[] strs = Console.ReadLine().ToCharArray();

                char res = ' ';

                int charindex = 0;

                strs[0] = char.ToUpper(strs[0]);

                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i] == '.')
                    {
                        charindex = i;
                        res = strs[i];
                    }
                    if (i == charindex + 2) strs[i] = Char.ToUpper(strs[i]);
                }

                StreamWriter writer = new StreamWriter(file1);

                writer.Write(String.Join(null, strs)+"\n");
                writer.Close();
            }
        }
    }
}
