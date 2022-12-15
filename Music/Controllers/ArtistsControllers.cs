using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Music.Models;

namespace Music.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }

    [HttpPost("/artists/delete")]
    public ActionResult Delete()
    {
      Artist.ClearAll();
      return View();
    }
  }
}