using System;

namespace pz_017
{
    class Program
    {
        static Random uuu = new Random();

        static int NewSizeForArray(int[] a)
        {
            int i = 1;
            int j = 0;
            while (i != 0)
            {
                i = a[j];
                j++;
            }
            return j;

        }

        static int MyNumbers(int[] a)
        {
            int[] sss = new int[a.Length];
            int j = 0;
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0 & a[i] % 2 == 0)
                {
                    sss[j] = a[i];
                    j++;
                }
            }
            Array.Resize(ref sss, NewSizeForArray(sss));
            for (int i = 0; i < sss.Length; i++) result += sss[i];
            return result;
        }
        static void Main(string[] args)
        {
            int[] abcdefghgdflfsfg = new int[10];
            for (int i = 0; i < abcdefghgdflfsfg.Length; i++) abcdefghgdflfsfg[i] = uuu.Next(byte.MaxValue);
            Console.WriteLine(MyNumbers(abcdefghgdflfsfg));
        }
    }
}
