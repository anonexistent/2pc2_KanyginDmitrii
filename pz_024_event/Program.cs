using System;

delegate void MD(int a);

namespace pz_024_event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wait wait = new Wait();
            for (int i = 0; i < 100; i++)
            {
                Counter a= new Counter(i);
                Wait.ME200+= i == 20 ? (i) => { Console.WriteLine("warning!!!!\t200\twarning!!!!"); } : null;
                
                
            }
        }
    }
}
