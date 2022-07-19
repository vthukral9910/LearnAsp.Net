using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;   

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ID=1,Name="ABC",Cuisin=CuisinType.FRNECH},
                new Restaurant{ID=2,Name="XYZ",Cuisin=CuisinType.INDIAN},
                new Restaurant{ID=3,Name="MNO",Cuisin=CuisinType.ITALIAN}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(restaurant => restaurant.Name);
        }
        public Restaurant GetRestaurantDetails(int id)
        {
            return restaurants.FirstOrDefault(restaurant => restaurant.ID == id);
        }
    }
}
