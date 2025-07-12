using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }

        /// <summary>
        /// Referans veren kişinin adı
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Referans veren kişinin unvanı (örneğin: .NET Developer, DevOps, vb.)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Referans veren kişinin yorumları
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Referans veren kişinin resmi
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
