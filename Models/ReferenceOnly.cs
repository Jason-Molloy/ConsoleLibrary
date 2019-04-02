namespace console_library.Models
{
  abstract class ReferenceOnly
  {
    public string Id { get; set; }

    public ReferenceOnly(string id)
    {
      Id = id;
    }
  }
}