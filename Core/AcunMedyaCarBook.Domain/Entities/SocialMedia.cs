using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        
        /// <summary>
        /// Sosyal medya platformunun adı (örneğin: Facebook, Twitter, Instagram)
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Sosyal medya platformunun URL'si
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// Sosyal medya platformunun simgesi (ikon) URL'si
        /// </summary>
        public string Icon { get; set; }
    }
}
