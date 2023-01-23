using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
        public class EBiletler
    {
        public int BiletNo { get; set; }
        public string YolcuAdSoyad { get; set; }
        public int YolcuKoltukNo { get; set; }
        public string OtobusTipi { get; set; }
        public string OtobusFirma { get; set; }
        public string OtobusKalkisYeri { get; set; }
        public string OtobusVarisYeri { get; set; }
        public string OtobusKalkisZamani { get; set; }
        public string OtobusVarisZamani { get; set; }
        public string OtobusKalkisTarihi { get; set; }
        public string OtobusVarisTarihi { get; set; }
        public int BiletFiyati { get; set; }
        public int YolcuNo { get; set; }
    }
}
