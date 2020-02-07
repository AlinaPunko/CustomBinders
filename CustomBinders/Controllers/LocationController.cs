using CustomBinders.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomBinders.Controllers
{
    public class LocationController : Controller
    {
        [Route("api/location")]
        public IActionResult CreatePoint(Point point)
        {
            return Json(point);
        }
    }
}