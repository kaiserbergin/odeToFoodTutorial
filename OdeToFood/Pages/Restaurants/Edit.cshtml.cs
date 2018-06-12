using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages.Restaurants {
    public class EditModel : PageModel {
        private IRestaurantData restaurantData;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData) {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int id) {
            Restaurant = restaurantData.Get(id);
            if (Restaurant == null) {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.Id });
            }
            return Page();
        }
    }
}