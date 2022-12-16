using System.Collections.Generic;

namespace Music.Models
{
  public class Record
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _songs = new List<Record> { };

    public Record(string title)
    {
      Title = title;
      _songs.Add(this);
      Id = _songs.Count;
    }

    public static List<Record> GetAll()
    {
      return _songs;
    }

    public static void ClearAll()
    {
      _songs.Clear();
    }

    public static Record Find(int searchId)
    {
      return _songs[searchId - 1];
    }

  }
}
