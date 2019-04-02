namespace console_library.Models
{
  abstract class Borrowable
  {
    public bool Available { get; set; }
    public string Id { get; set; }

    public Borrowable(string id)
    {
      Available = true;
      Id = id;
    }
  }
}