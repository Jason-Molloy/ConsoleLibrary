using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Book wtse = new Book("Where the Sidewalk Ends", "Shel Silverstien");
      Book lotr = new Book("Lord of the Rings", "JRR Tolkien");
      Library myLibrary = new Library("Jason's Library");

      Console.Clear();
      Console.WriteLine($"Welcome to {myLibrary.Name}.");
      //Console.WriteLine($"{lotr.Title} {lotr.Author} - {(lotr.Available ? "Available" : "Checked Out")}");

      myLibrary.AddBook(wtse);
      myLibrary.AddBook(lotr);


      myLibrary.PrintBooks();
    }
  }
}
