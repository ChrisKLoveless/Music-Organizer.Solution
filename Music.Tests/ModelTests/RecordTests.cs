using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music.Models;
using System.Collections.Generic;
using System;

namespace Music.Tests
{
  [TestClass]
  public class RecordTests
  {
    [TestMethod]
    public void Constructor_CreatesInstanceofRecord_Record()
    {
      Record newRecord = new Record();
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
  }
}