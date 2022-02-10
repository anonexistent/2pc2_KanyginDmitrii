using System;
using System.Collections.Generic;
using System.Text;

namespace pz_020
{
    class BookCard
    {
        public long id;
        public string author;
        public string title;
        public int year;
        public string condition;
        public BookCard(long Id= -1, string Author="no author", string Title="no title", int Year= -1, string Condition="no condition")
        {
            id = Id;
            author = Author;
            title = Title;
            year = Year;
            condition = Condition;            
        }
        public BookCard(string Author = "no author", string Title = "no title", int Year = -1, string Condition = "no condition", long Id = -1)
        {
            author = Author;
            title = Title;
            year = Year;
            condition = Condition;
            id = Id;
        }

        public void GetBookInfo()
        {
            Console.WriteLine($"BookInfo: \n id {id} \n author {author} \n title {title} \n year {year} \n condition {condition}");
        }
    }
}
