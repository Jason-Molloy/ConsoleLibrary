using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      bool inLibrary = true;
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

      Enum activeMenu = Menus.CheckoutBook;

      Console.Clear();
      Console.WriteLine($"Welcome to {myLibrary.Name}.");
      Console.WriteLine("Would you like to check out a book from our (A)vailable books, (R)eturn a book? Q to quit.");
      while (inLibrary)
      {
        switch (activeMenu)
        {
          case Menus.CheckoutBook:
            myLibrary.PrintBooks();
            break;
          case Menus.ReturnBook:
            myLibrary.PrintCheckedOut();
            break;
        }
        string selection = Console.ReadLine().ToLower();
        switch (selection)
        {
          case "r":
            Console.Clear();
            activeMenu = Menus.ReturnBook;
            break;
          case "a":
            Console.Clear();
            activeMenu = Menus.CheckoutBook;
            break;
          case "q":
            Console.Clear();
            inLibrary = false;
            break;
          default:
            if (activeMenu.Equals(Menus.CheckoutBook))
            {
              myLibrary.Checkout(selection);
            }
            else
            {
              myLibrary.Return(selection);
            }
            break;
        }
        // if (selection == "q")
        // {
        //   inLibrary = false;
        // }
        // else
        // {
        //   myLibrary.Checkout(selection);
        // }
      }
    }
    public enum Menus
    {
      CheckoutBook,
      ReturnBook
    }
  }
}
