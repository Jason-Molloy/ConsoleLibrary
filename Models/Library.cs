using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; private set; }
    private List<Book> Books { get; set; }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public void PrintBooks()
    {
      foreach (Book book in Books)
      {
        System.Console.WriteLine($"{book.Title} by {book.Author} -- Status: {(book.Available ? "Available" : "Checked Out")}");
      }
    }

    public Library(string name)
    {
      Name = name;
      Books = new List<Book>();
    }
  }
}