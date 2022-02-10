using System;
using System.Collections.Generic;
using System.Text;

namespace pz_020
{ 
    class BookCard
    {
        public ulong id;
        public string author;
        public string title;
        public int year;
        public string condition;
        public void GetBookInfo()
        {
            Console.WriteLine($"BookInfo: \n id {id} \n author {author} \n title {title} \n year {year} \n condition {condition}");
        }
    }
}
