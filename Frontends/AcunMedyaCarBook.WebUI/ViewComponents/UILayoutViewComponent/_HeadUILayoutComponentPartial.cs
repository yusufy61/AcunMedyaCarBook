using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebUI.ViewComponents.UILayoutViewComponent
{
    public class _HeadUILayoutComponentPartial : ViewComponent
    {
        /// <summary>
        /// partialdan daha kullanışlı ve daha güvenli bir yapıdır.
        /// ayrı bir partail view için sınıf oluşturup bu sınıftan verileri alma işlemini sağlıyor.
        /// 
        /// Genellikle bu fonksiyonun ismi Invoke olarak kullanılır.
        /// Partial view ler url üzerinden direk erişim sağlanabiliyor. Fakat View component yapısında url üzerinden direk erişim sağlanmıyor.
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
