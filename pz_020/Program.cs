using System;

namespace pz_020
{  
    class Program
    {        
        static void print(object a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(a);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            ConplexNumber one = new ConplexNumber(-3.99f, -5.0109f);
            ConplexNumber two = new ConplexNumber(2,0);
            ConplexNumber three = new ConplexNumber(0,-6);

            ConplexNumber four = new ConplexNumber(-4.009284879105f, 9);
            ConplexNumber five = new ConplexNumber(5, -10.995348957345f);
            ConplexNumber six = new ConplexNumber();


            ConplexNumber.GetConplexNumber(one);
            ConplexNumber.GetConplexNumber(two);
            ConplexNumber.GetConplexNumber(three);

            ConplexNumber.GetConplexNumber(four);
            ConplexNumber.GetConplexNumber(five);

            ConplexNumber.GetConplexNumber(six);

            print(five.ToString() + "\n");

            

            
        }
    }
}
