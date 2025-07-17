using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.ViewComponents.UILayoutViewComponent
{
    public class _MainCoverUILayoutComponentPartial : ViewComponent
    {
        /// <summary>
        /// Ana Kapak bölümünün eklendiği partial alanı
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
