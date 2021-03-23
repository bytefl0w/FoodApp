using FoodApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Erik's Pizza", Location = "Boston", Cuisine=CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Casa Blanca", Location = "Madison", Cuisine=CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Indian Food Restaurant", Location = "Washington", Cuisine = CuisineType.Indian }
            };
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
