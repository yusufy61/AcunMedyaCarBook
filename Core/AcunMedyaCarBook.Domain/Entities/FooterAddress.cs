using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class FooterAddress
    {
        public int FooterAddressID { get; set; }

        /// <summary>
        /// Şirketin kendi tanımladığı alan
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Şirketin adresi
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Şirketin telefon numarası
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Şirketin e-posta adresi
        /// </summary>
        public string Email { get; set; }
    }
}
