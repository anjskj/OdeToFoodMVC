using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id=1, Name="Anjas Pizza", Cuisine=CuisineType.Italian},
                new Restaurant {Id=2, Name="Kalles Korvar", Cuisine=CuisineType.German},
                new Restaurant {Id=3, Name="Indiana Jones", Cuisine=CuisineType.Indian}

            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=>r.Name);
        }
    }
}
