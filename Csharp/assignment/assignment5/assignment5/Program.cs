using System;


public class Books
{
  
    public string BookName { get; set; }
    public string AuthorName { get; set; }

    
    public Books(string bookName, string authorName)
    {
        BookName = bookName;
        AuthorName = authorName;
    }

   
    public void Display()
    {
        Console.WriteLine($"Book Name: {BookName}");
        Console.WriteLine($"Author Name: {AuthorName}");
        Console.WriteLine();
    }
}


public class BookShelf
{
    
    private Books[] books = new Books[5];

    
    public Books this[int index]
    {
        get
        {
            if (index >= 0 && index < books.Length)
            {
                return books[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
        }
        set
        {
            if (index >= 0 && index < books.Length)
            {
                books[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
        }
    }
}


class Program
{
    static void Main()
    {
        
        BookShelf shelf = new BookShelf();

       
        shelf[0] = new Books("Book1", "Author1");
        shelf[1] = new Books("Book2", "Author2");
        shelf[2] = new Books("Book3", "Author3");
        shelf[3] = new Books("Book4", "Author4");
        shelf[4] = new Books("Book5", "Author5");

        
        Console.WriteLine("Books on the BookShelf:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Book {i + 1}:");
            shelf[i].Display();
            Console.Read();
        }
    }
}
