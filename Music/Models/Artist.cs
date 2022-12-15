using System.Collections.Generic;

namespace Music.Models
{
  public class Artist
  {
    public string ArtistName { get; set; }
    public int Id { get; }
    public static List<Artist> _label = new List<Artist> { };

    public Artist(string artistName)
    {
      ArtistName = artistName;
      _label.Add(this);
      Id = _label.Count;
    }

    public static void ClearAll()
    {
      _label.Clear();
    }

    public static List<Artist> GetAll()
    {
      return _label;
    }
  }
}