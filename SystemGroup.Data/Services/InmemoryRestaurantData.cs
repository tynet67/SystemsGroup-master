using System;
using System.Collections.Generic;
using System.Linq;
using SystemGroup.Data.


namespace SystemGroup.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Cuisine =CusineType.Italian},
                new Restaurant {Id = 2, Name = "Tersiguels", Cuisine =CusineType.Frence},
                new Restaurant {Id = 3, Name = "mango", Cuisine =CusineType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetAll()

        {
            return restaurants.OrderBy(r => r.Name);

        }



    }

}
