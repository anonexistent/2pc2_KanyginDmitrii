using System;

namespace pz_020
{
    class Program
    {
        static void book1()
        {
            BookCard a = new BookCard();
            a.author = "fet a a";
            a.condition = "gooooood(good)";
            a.title = "cactus";
            a.year = 1881;
            a.id =10;
            a.GetBookInfo();
        }
        static void book2()
        {
            BookCard a = new BookCard();
            a.author = "qwe";
            a.condition = "bad";
            a.title = "bird";
            a.year = 1999;
            a.id = 11;
            a.GetBookInfo();
        }
        static void Main(string[] args)
        {
            book1();
            book2();
        }
    }
}
