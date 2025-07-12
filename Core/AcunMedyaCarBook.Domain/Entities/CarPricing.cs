using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    /// <summary>
    /// Pricing tablosuyla Car tablosu arasında ilişkiyi temsil eder.
    /// </summary>
    public class CarPricing
    {
        public int CarPricingID { get; set; }


        /// <summary>
        /// Car tablosuyla ilişkilendirme
        /// </summary>
        public int CarID { get; set; }
        public Car Car { get; set; }

        /// <summary>
        /// picing tablosuyla ilişkilendirme
        /// </summary>
        public int PricingID { get; set; }
        public Pricing Pricing { get; set; }

        /// <summary>
        /// Bu fiyatlandırmanın miktarını temsil eder.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
