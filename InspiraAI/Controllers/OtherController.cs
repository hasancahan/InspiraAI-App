using Microsoft.AspNetCore.Mvc;

namespace InspiraAI.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
