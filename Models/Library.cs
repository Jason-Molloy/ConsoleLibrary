using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; private set; }
    private List<Book> Books { get; set; }
    private List<Book> CheckedOut { get; set; }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1}) {Books[i].Title} by {Books[i].Author} -- Status: {(Books[i].Available ? "Available" : "Checked Out")}");
      }
    }

    public void Checkout(Book)
    {

    }

    public Library(string name)
    {
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }
  }
}