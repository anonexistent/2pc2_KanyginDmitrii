using System;
using System.IO;

namespace pz_015
{
    class Program
    {
        static void Main(string[] args)
        {
            //  удалить строчку К из файла
            int K = int.Parse(Console.ReadLine());

            string file = @"C:\fet\piece.txt";

            string[] filstrs = File.ReadAllLines(file);

            if (K > filstrs.Length)
            {
                Console.WriteLine("nonono");
            }
            else
            {
                Console.WriteLine("\t\t\t\t" + filstrs[K]);

                Array.Clear(filstrs, K, 1);
                Array.Resize(ref filstrs, filstrs.Length - 1);

                FileStream file0 = new FileStream(file, FileMode.Truncate);
                StreamWriter writer = new StreamWriter(file0);

                for (int i = 0; i < filstrs.Length; i++) writer.WriteLine(filstrs[i]);
                writer.Close();
            }
        }
    }
}
