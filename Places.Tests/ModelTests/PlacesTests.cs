using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;

namespace Places.Tests
{
    [TestClass]
    public class PlacesTest : IDisposable
    {
        public void Dispose()
        {
        Place.ClearAll();
        }

       [TestMethod] 
       public void GetDescription_ReturnCityDescription_String()
        {
            string city = "New York";
            int days = 10;
            string person = "Tom";
            string journal = "one";
            Place newPlace = new Place(city, days, person, journal);
            string result = newPlace.CityName;
            Assert.AreEqual(city, result);
        }
        [TestMethod] 
        public void GetDescription_ReturnsDaysDescription_String()
        {
            string city = "New York";
            int days = 10;
            string person = "Tom";
            string journal = "one";
            Place newPlace = new Place(city, days, person, journal);
            int result = newPlace.Days;
            Assert.AreEqual(days, result);
        }
        [TestMethod] 
        public void GetDescription_ReturnsPersonDescription_String()
        {
            string city = "New York";
            int days = 10;
            string person = "Tom";
            string journal = "one";
            Place newPlace = new Place(city, days, person, journal);
            string result = newPlace.Person;
            Assert.AreEqual(person, result);
        }
        [TestMethod] 
        public void GetDescription_ReturnsJournalDescription_String()
        {
            string city = "New York";
            int days = 10;
            string person = "Tom";
            string journal = "one";
            Place newPlace = new Place(city, days, person, journal);
            string result = newPlace.Journal;
            Assert.AreEqual(journal, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_PlaceList()
        {
        //Arrange
        List<Place> newList = new List<Place> { };
        //Act
        List<Place> result = Place.GetAll();
        //Assert
        CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_PlaceList()
        {
        //Arrange
        string city = "New York";
        int days = 10;
        string person = "Tom";
        string journal = "one";
        Place newPlace = new Place(city, days, person, journal);
        List<Place> newList = new List<Place> { newPlace };
        //Act
        List<Place> result = Place.GetAll();
        //Assert
        CollectionAssert.AreEqual(newList, result);
        }


    }
}