namespace _10_GenericTypesCollections.Models

{
    public class Members
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Members(int memberId, string name, string email)
        {
            MemberId = memberId;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
            {
                Console.WriteLine("Maximum 3 books allowed");
            }
            else
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Book borrowed: {book.Title}");
            }
        }

        public void ReturnBook(int bookId)
        {
            foreach (var item in BorrowedBooks)
            {
                if (item.BookId == bookId)
                {
                    BorrowedBooks.Remove(item);
                    Console.WriteLine($"Book returned: {item.Title}");
                    break;
                }
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("No borrowed books");
            }
            else
            {
                foreach (var item in BorrowedBooks)
                {
                    item.DisplayInfo();
                }
            }
        }
    }
}