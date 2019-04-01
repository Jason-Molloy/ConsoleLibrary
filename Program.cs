using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Library myLibrary = new Library("Jason's Library");
      Book wtse = new Book("Where the Sidewalk Ends", "Shel Silverstien");
      Book lotr = new Book("Lord of the Rings", "JRR Tolkien");
      Book tbk = new Book("The Brothers Karamazov", "Fyodor Dostoyevsky");
      Book fwtbt = new Book("For Whom the Bell Tolls", "Ernest Hemingway");
      Book tspe = new Book("The Three Stigmata of Palmer Eldritch", "Philip K. Dick");
      Book md = new Book("Moby Dick", "Herman Melville");
      Book pf = new Book("Pale Fire", "Vladmir Nabokov");
      Book gr = new Book("Gravity's Rainbow", "Thomas Pynchon");

      myLibrary.AddBook(wtse);
      myLibrary.AddBook(lotr);
      myLibrary.AddBook(tspe);
      myLibrary.AddBook(fwtbt);
      myLibrary.AddBook(tbk);
      myLibrary.AddBook(pf);
      myLibrary.AddBook(md);
      myLibrary.AddBook(gr);

      Console.Clear();
      Console.WriteLine($"Welcome to {myLibrary.Name}.");
      myLibrary.PrintBooks();
      Console.WriteLine("Select a number to check out the book (Q)uit or (R)eturn a book");
      string selection = Console.ReadLine();
      myLibrary.Checkout(selection);
    }
  }
}
