using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers {
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone() {
            return "867-5309";
        }

        [Route("[action]")]
        public string Address() {
            return "USA";
        }
    }
}