using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }

        /// <summary>
        /// ödeme planının adı (örneğin: günlük, aylık, haftalık)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Car <-> Pricing ilişkisini temsil eder.
        /// CarPricing ise ara tabosudur ve Car ile Pricing arasındaki ilişkiyi yönetir.
        /// </summary>
        public List<CarPricing> CarPricings { get; set; }
    }
}
