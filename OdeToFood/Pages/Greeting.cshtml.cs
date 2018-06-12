using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter greeter;
        public string CurrentGreeting { get; set; }

        public GreetingModel(IGreeter greeter) {
            this.greeter = greeter;

        }
        public void OnGet(string name)
        {
            CurrentGreeting = $"{name}: {greeter.GetMessageOfTheDay()}";
        }
    }
}