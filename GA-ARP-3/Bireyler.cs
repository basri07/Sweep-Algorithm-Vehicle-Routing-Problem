using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ARP_3
{
    public class Bireyler:ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public Bireyler(String Kromozom, String AraclarinGuzergahi, int Uygunluk, int ToplamYol, List<Araclar> AraclarSirasi)
        {
            this.AraclarinGuzergahi = AraclarinGuzergahi;
            this.Kromozom = Kromozom;
            this.Uygunluk = Uygunluk;
            this.ToplamYol = ToplamYol;
            this.AraclarSirasi = AraclarSirasi;
        }

        public String Kromozom { get; set; }
        public String AraclarinGuzergahi { get; set; }
        public int Uygunluk { get; set; }
        public int ToplamYol { get; set; }
        public List<Araclar> AraclarSirasi { get; set; }
    }
}
