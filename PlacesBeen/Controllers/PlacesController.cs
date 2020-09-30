using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller 
  {
    [HttpGet("/places")]
  public ActionResult Index()               //Common RESTful route name when you want to display list of all objects (GET)
  {
    List<Place> allPlaces = Place.GetAll();
    return View(allPlaces);
  } 
  [HttpPost("/places")]
   public ActionResult Create(string cityName, string days, string travelBuddy, string dishes)   //Creates a new item on the server (POST)
  {
    int daysStayed = int.Parse(days);
    Place myPlace = new Place(cityName, daysStayed, travelBuddy, dishes);
    return RedirectToAction("Index");
  }

  [HttpGet("/places/new")]
  public ActionResult New()           //Offers form to create new object (GET)
  {
    return View();
  }    

  [HttpGet("/places/{id}")]
  public ActionResult Show(int id)
  {
    Place foundPlace = Place.Find(id);   //Create .Find() method in class
    return View(foundPlace);
  }

  [HttpPost("/places/{id}")]
  public ActionResult Update(int id)
  {
    Place foundPlace = Place.Find(id);
    foundPlace.VisitAgain = true;
    return RedirectToAction("Index");
  }


  }
}

