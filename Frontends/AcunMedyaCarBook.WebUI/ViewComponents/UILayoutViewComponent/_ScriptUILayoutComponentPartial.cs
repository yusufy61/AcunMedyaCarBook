using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.ViewComponents.UILayoutViewComponent
{
    public class _ScriptUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
