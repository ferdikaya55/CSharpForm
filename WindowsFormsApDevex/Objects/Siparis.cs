using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApDevex.Objects
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public int MusteriId { get; set; }
        public int KurId { get; set; }
        public int OdemeId { get; set; }
        public int TeslimId { get; set; }
        public int SiparisNo { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public double KurDegeri { get; set; }
    }
}
