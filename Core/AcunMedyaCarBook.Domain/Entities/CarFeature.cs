using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        
        public int CarID { get; set; }
        public Car Car { get; set; }


        public int FeatureID { get; set; }
        public Feature Feature { get; set; }

        /// <summary>
        /// Bu özellik var mı?
        /// Bu özelliğe erişim var mı?
        /// </summary>
        public bool Available { get; set; }
    }
}
