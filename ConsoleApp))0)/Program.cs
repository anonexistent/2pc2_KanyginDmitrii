using System;
using System.IO;

namespace ConsoleApp__0_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pls enter file name pls: ");

            FileStream file1 = new FileStream(new string(@"C:\fet\" + @$"{Console.ReadLine()})"), FileMode.Append);

            string dirrr = @"C:\fet\";

            DirectoryInfo dirinfo = new DirectoryInfo(dirrr);

            dirinfo.

            FileStream file0 = new FileStream(@"C:\fet\no.txt", FileMode.Append);

            string[] str0 = Console.ReadLine().Split('.');

            StreamWriter writer = new StreamWriter(file0);

            //65-90 upper
            //97-122 down

            //for (int i = 0; i < str0.Length-1; i++)
            //{
            // if (str0[i-1].EndsWith('.')) char.ToUpper(str0[i][0]);
            //}

            //for (int i = 0; i < str0.Length; i++)
            //{
            // Console.WriteLine(str0[i]);
            //}

            //for (int i = 0; i < str0.Length; i++)
            //{
            // char.ToUpper(str0[i][0]);
            // Console.WriteLine(str0[i]);
            //}

            for (int i = 0; i < str0.Length; i++)
            {
                writer.Write(str0[i]);
            }

            writer.WriteLine("\n\n");
            writer.Close();
        }
    }
}
