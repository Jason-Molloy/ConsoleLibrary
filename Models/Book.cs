namespace console_library.Models
{
  class Book : Borrowable
  {
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author, string id, bool available) : base(id)
    {
      Title = title;
      Author = author;
    }
  }
}