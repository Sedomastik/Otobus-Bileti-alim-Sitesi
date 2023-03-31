using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobüs_Bİleti_Alim_Satim_Otomasyonu.Entity
{
    public class bilet
    {
        public int Pnrnumara { get; set; }
        public string ad { get; set; }
        public string Soyad { get; set; }
        public int telnum { get; set; }
        public string email { get; set; }
        public int tcnum { get; set; }
        public string cinsiyet { get; set; }
        public string kalkısnok { get; set; }
        public string donusnok { get; set; }
        public string yolskl { get; set; }
        public int gidistrh { get; set; }
        public int donustrh { get; set; }
        public int koltuknum { get; set; }

    }   
}
