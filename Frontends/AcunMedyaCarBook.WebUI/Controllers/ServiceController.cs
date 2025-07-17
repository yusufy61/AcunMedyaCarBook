using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
