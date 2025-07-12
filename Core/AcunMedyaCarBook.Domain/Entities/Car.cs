using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Domain.Entities
{
    /// <summary>
    /// Arabanın temel özelliklerinin bulunduğu sınıf
    /// </summary>
    public class Car
    {
        public int CarID { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }

        /// <summary>
        /// arabanın kapak fotoğrafı
        /// </summary>
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// arabanın kaç km'de olduğunu gösterir
        /// </summary>
        public int Km { get; set; }

        /// <summary>
        /// vites türü (otomatik, manuel vb.)
        /// istersek bunu enum tarzında kullanabiliriz
        /// </summary>
        public string Transmission { get; set; }

        /// <summary>
        /// koltuk sayısı (2,4, ..)
        /// </summary>
        public byte Seat { get; set; }

        /// <summary>
        /// bagaj kapasitesi (1, 2, 3, ..)
        /// </summary>
        public byte Luggage { get; set; }

        /// <summary>
        /// Yakıt tipini geri döndürmektedir
        /// </summary>
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }

        /// <summary>
        /// Arabalara ait özelliklerin tutulduğu liste
        /// </summary>
        public List<CarFeature> CarFeatures { get; set; }

        /// <summary>
        /// Arabanın açıklamalarının tutulduğu liste
        /// </summary>
        public List<CarDescription> CarDescriptions { get; set; }


    }
}
