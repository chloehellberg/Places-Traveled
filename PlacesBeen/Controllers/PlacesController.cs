using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller 
  {
    [HttpGet("/places")]
  public ActionResult Index() 
  {
    List<Place> allPlaces = Place.GetAll();
    return View(allPlaces);
  } 
  [HttpPost("/places")]
   public ActionResult Create(string cityName) 
  {
    Place myPlace = new Place(cityName);
    return RedirectToAction("Index");
  }

  [HttpGet("/places/new")]
  public ActionResult New()
  {
    return View();
  }    


    }
  }

