using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        
        /// <summary>
        /// İletişim formunda kullanıcının adı
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// İletişim formunda kullanıcının e-posta adresi
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// konu başlığı
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// İletişim formunda kullanıcının mesajı
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// İletişim formunun gönderildiği tarih ve saat
        /// </summary>
        public DateTime SendDate { get; set; }
    }
}
