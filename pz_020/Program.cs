using System;

namespace pz_020
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCard book1 = new BookCard();
            BookCard book2 = new BookCard(11, "gweerhg","ertetwert",1999, "ewrgter");
            BookCard book3 = new BookCard(-1,"2342");

            book1.GetBookInfo();
            book2.GetBookInfo();
            book3.GetBookInfo();

        }
    }
}
