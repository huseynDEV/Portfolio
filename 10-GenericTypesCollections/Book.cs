using System;
using System.Net;

namespace _10_GenericTypesCollections
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfProse { get; set; }
        public int PageCount { get; set; }

        public Book(int bookId, string title, string author, int yearOfProse, int pageCount)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            YearOfProse = yearOfProse;
            PageCount = pageCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[{BookId}] {Title} - {Author} ({YearOfProse}) - {PageCount} pages");
        }
    }
}


