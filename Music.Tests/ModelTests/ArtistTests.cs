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
  }
}