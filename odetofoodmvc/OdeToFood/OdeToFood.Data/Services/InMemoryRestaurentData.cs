using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    class InMemoryRestaurentData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurentData()
        {
            restaurants = new List<Restaurant>();
            {
                new Restaurant { Id = 1, Name = "La casa Vito Morreale", Cuisine = CuisineType.Italian};
                new Restaurant { Id = 2, Name = "Le Poivron Bleu", Cuisine = CuisineType.French };
                new Restaurant { Id = 3, Name = "Le Karachi", Cuisine = CuisineType.Indian };
            }
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
