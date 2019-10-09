using System.Collections.Generic;

namespace Places.Models
{
    public class Place 
    {
        public string CityName {get; set;}
        public int Days {get; set;}
        public string Person {get; set;}
        public string Journal {get; set;}

         private static List<Place> _instances = new List<Place> {};



    
    public Place (string cityName, int days, string person, string journal)
    {
        CityName = cityName;
        Days = days;
        Person = person;
        Journal = journal;
        _instances.Add(this);

    }

  public static List<Place> GetAll()
    {
      return _instances;
    }
    }

}
