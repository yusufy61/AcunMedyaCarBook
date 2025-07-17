using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.ViewComponents.UILayoutViewComponent
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        /// <summary>
        /// Footer bölümünün eklendiği partial alanı
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
