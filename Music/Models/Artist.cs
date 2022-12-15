using System.Collections.Generic;

namespace Music.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public int Id { get; }
    public static List<Artist> _label = new List<Artist> { };

    public Artist(string artistName)
    {
      Name = artistName;
      _label.Add(this);
      Id = _label.Count;
    }

    public static void ClearAll()
    {
      _label.Clear();
    }
  }
}