using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class CarDescription
    {
        public int CarDescriptionID { get; set; }
        
        /// <summary>
        /// Hangi arabanın bağlı olduğu belirten prop
        /// </summary>
        public int CarID { get; set; }
        public Car Car { get; set; }

        /// <summary>
        /// Arabanın açıklaması
        /// </summary>
        public string Details { get; set; }

    }
}
