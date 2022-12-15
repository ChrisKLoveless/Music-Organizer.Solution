using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music.Models;
using System.Collections.Generic;
using System;

namespace Music.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }
  
    [TestMethod]
    public void Constructor_CreatesInstanceofArtist_Artist()
    {
      Artist mac = new Artist("mac");
      Assert.AreEqual(typeof(Artist), mac.GetType());
    }

    [TestMethod]
    public void Constructor_ReturnsArtistName_String()
    {
      string artistName = "mac";
      Artist mac = new Artist(artistName);
      Assert.AreEqual(artistName, mac.Name);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      string artistName = "mac";
      Artist mac = new Artist(artistName);
      Assert.AreEqual(1, mac.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      string name1 = "mac";
      string name2 = "miller";
      Artist artist1 = new Artist(name1);
      Artist artist2 = new Artist(name2);
      List<Artist> artistList = new List<Artist>{artist1, artist2};
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(artistList, result);
    }
  }
}