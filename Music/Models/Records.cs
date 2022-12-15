using System.Collections.Generic;

namespace Music.Models
{
  public class Record
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _instances = new List<Record> { };
  }
}
