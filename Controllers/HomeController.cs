using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("result")]
        public IActionResult Result(string your_name, string dojo_location, string favorite_language, string comment)
        {
            ViewBag.your_name = your_name;
            ViewBag.dojo_location = dojo_location;
            ViewBag.favorite_language = favorite_language;
            ViewBag.comment = comment;
            return View();
        }
    }
}