using Microsoft.AspNetCore.Mvc;

namespace InspiraAI.Controllers
{
    public class AiController : Controller
    {
        public IActionResult DiscoverArtworks()
        {
            return View();
        }

        public IActionResult GenerateArtworks()
        {
            return View();
        }

    }
}
