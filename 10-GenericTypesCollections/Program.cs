// See https://aka.ms/new-console-template for more information
using _10_GenericTypesCollections;
using _10_GenericTypesCollections.Models;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
        Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
        Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
        Book book4 = new Book(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
        Book book5 = new Book(5, "Qiriq Budaq", "Elcin", 1998, 350);

        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
        book4.DisplayInfo();
        book5.DisplayInfo();


        List<Members> list = new List<Members>();

        list.Add(new Members(1, "Ali Memmedov", "ali@mail.com"));
        list.Add(new Members(2, "Leyla Hesenova", "leyla@mail.com"));
        list.Add(new Members(3, "Vuqar Eliyev", "vuqar@mail.com"));

        Members m = list[0];

        m.BorrowBook(book1);
        m.BorrowBook(book2);

        m.DisplayBorrowedBooks();

        m.ReturnBook(1);
        m.DisplayBorrowedBooks();

        m.BorrowBook(book3);
        m.BorrowBook(book4);
        m.BorrowBook(book5);

        Bookmanager uzv = new Bookmanager();

        uzv.AddBook(book1);
        uzv.AddBook(book2);
        uzv.AddBook(book3);
        uzv.AddBook(book4);
        uzv.AddBook(book5);

        foreach (var item in uzv.GetBooksByAuthor("George Orwell"))
            item.DisplayInfo();

        foreach (var item in uzv.GetBooksByAuthor("Cingiz Aytmatov"))
            item.DisplayInfo();

        foreach (var item in uzv.GetBooksByAuthor("Jack London"))
            item.DisplayInfo();

        Console.WriteLine("tapilan: " + uzv.GetBooksByAuthor("Dostoyevski").Count);

        uzv.AddToWaitingQueue("Nigar");
        uzv.AddToWaitingQueue("Resad");
        uzv.AddToWaitingQueue("Sebine");

        Console.WriteLine("queue: " + uzv.WaitingQueue.Count);
        Console.WriteLine("xidmet: " + uzv.ServeNextInQueue());
        Console.WriteLine("qalan: " + uzv.WaitingQueue.Count);

        uzv.ServeNextInQueue();
        Console.WriteLine("qalan: " + uzv.WaitingQueue.Count);

        uzv.ServeNextInQueue();
        Console.WriteLine("qalan: " + uzv.WaitingQueue.Count);

        uzv.ReturnBook(book1);
        uzv.ReturnBook(book2);
        uzv.ReturnBook(book3);

        Console.WriteLine("stack: " + uzv.RecentlyReturned.Count);

        var last = uzv.GetLastReturnedBook();
        if (last != null) last.DisplayInfo();

        uzv.RecentlyReturned.Pop();
        Console.WriteLine("stack: " + uzv.RecentlyReturned.Count);

        var last2 = uzv.GetLastReturnedBook();
        if (last2 != null) last2.DisplayInfo();

        var f = uzv.SearchByTitle("1984");
        if (f != null) f.DisplayInfo();

        var nf = uzv.SearchByTitle("Harry Potter");
        if (nf == null) Console.WriteLine("tapilmadi");

        Console.WriteLine("books: " + uzv.Books.Count);
        Console.WriteLine("members: " + list.Count);
        Console.WriteLine("queue: " + uzv.WaitingQueue.Count);
        Console.WriteLine("stack: " + uzv.RecentlyReturned.Count);

        int min = uzv.Books[0].YearOfProse;
        int max = uzv.Books[0].YearOfProse;

        foreach (var i in uzv.Books)
        {
            if (i.YearOfProse < min) min = i.YearOfProse;
            if (i.YearOfProse > max) max = i.YearOfProse;
        }

        Console.WriteLine("min year: " + min);
        Console.WriteLine("max year: " + max);
    }
}
