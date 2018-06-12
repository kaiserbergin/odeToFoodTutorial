using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services {
    public class SqlRestaurantData : IRestaurantData {
        private OdeToFoodDBContext context;

        public SqlRestaurantData(OdeToFoodDBContext context) {
            this.context = context;
        }

        public Restaurant Add(Restaurant restaurant) {
            context.Restaurants.Add(restaurant);
            context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id) {
            return context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll() {
            return context.Restaurants.OrderBy(r => r.Id);
        }

        public Restaurant Update(Restaurant restaurant) {
            context.Attach(restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return restaurant;
        }
    }
}
