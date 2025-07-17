using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
