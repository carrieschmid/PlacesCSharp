using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> newList = Place.GetAll();
      return View(newList);
    }


  
    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/place")]
    public ActionResult Create(string cityName, int days, string person, string journal)
    {
      Place newPlace = new Place(cityName, days, person, journal);
      return RedirectToAction("Index");
    }


  }
}