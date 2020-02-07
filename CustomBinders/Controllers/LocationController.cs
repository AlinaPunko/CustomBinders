using CustomBinders.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomBinders.Controllers
{
    public class LocationController : Controller
    {
        [Route("api/location")]
        public IActionResult Index(Point point)
        {
            return Json(point);
        }
    }
}