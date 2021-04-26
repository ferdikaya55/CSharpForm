using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApDevex.Objects
{
    public class SiparisD
    {
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int? UrunMalzemeId { get; set; }
        public int? UrunHizmetId { get; set; }
        public int KurId { get; set; }
        public double Miktar { get; set; }
        public double BirimFiyati { get; set; }
        public double Tutar { get; set; }
        public string Birim { get; set; }
        public string SatirTipi { get; set; }
        public int KdvOrani { get; set; }
        public double KdvToplamTutari { get; set; }
        public double AraToplam { get; set; }
        public int IndirimOrani { get; set; }
        public double IndirimKazanci { get; set; }
        public double Toplam { get; set; }
        public double KurDegeri { get; set; }

    }
}
