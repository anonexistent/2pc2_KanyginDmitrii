using System;

namespace pz_025_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price[] spisok = new Price[3];

            for (int i = 0; i < 3; i++)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                float z = float.Parse(Console.ReadLine());

                spisok[i] = new Price(x, y, z);
            }

            Console.WriteLine(new string('_', 8));

            foreach (Price item in spisok) item.GetInfo();
        }
    }
}
