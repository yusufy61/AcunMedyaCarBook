using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
