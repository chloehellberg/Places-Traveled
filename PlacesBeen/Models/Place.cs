using System.Collections.Generic;
using System;

namespace PlacesBeen.Models
{
  public class Place                        // Create class
  {
    public string CityName { get; set; }            //Give it the property cityName (#2)
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { }; //For testing: public static List<Place> GetPlaces = new List<Place> { };
    public int DaysStayed { get; set; }
    public string TravelBuddy { get; set; }

    public string Dishes {get; set;}
    public bool VisitAgain { get; set; }


    public Place(string cityName, int daysStayed, string travelBuddy, string dishes)         // Create Place object (#1)
    {
      CityName = cityName;
      DaysStayed = daysStayed;
      TravelBuddy = travelBuddy;
      Dishes = dishes;
      VisitAgain = false;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll()   // Method that will return the full list of that particular instance
    {
      return _instances;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

//Places I've Visited: Portland   Places I Want To Visit Again: (blank)
//Do you want to visit again?: false;
//Portland Details: All the details and (They'll be a button that says "Visit Again?)
//"Visit Again" button will turn VisitAgain = true;
//Places I Want To Visit Again: Portland