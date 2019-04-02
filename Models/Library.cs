using System;
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

    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);
      {
        if (selectedBook == null)
        {
          Console.Clear();
          System.Console.WriteLine(@"Invalid Selection");
          return;
        }
        else
        {
          selectedBook.Available = false;
          CheckedOut.Add(selectedBook);
          Books.Remove(selectedBook);
          System.Console.WriteLine("Sucessfully checked out the book.");
        }
      }
    }

    private Book ValidateBook(string selection, List<Book> bookList)
    {
      int bookIndex;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 0 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }
    public Library(string name)
    {
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }
  }
}