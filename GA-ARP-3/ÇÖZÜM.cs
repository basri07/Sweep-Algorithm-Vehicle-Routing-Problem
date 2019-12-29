using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_ARP_3
{
    public partial class ÇÖZÜM : Form
    {
        public List<Musteri> MusteriListesi = new List<Musteri>();//ilki depo diğerleri müşteriler
        public List<Araclar> AracListesi = new List<Araclar>();//tüm araç isimleri ve kapasiteleri
        public List<Bireyler> ilkToplum = new List<Bireyler>();//ilki depo diğerleri müşteriler
        public List<Bireyler> yeniToplum = new List<Bireyler>();//ilki depo diğerleri müşteriler
        public int NesilSayisi = 200;//ardarda toplum dönüşümünü içerir nesil sayısı
        int BireySayisi = 300;//işlemlerdeki çözüm sayısıdır birey sayısı
        public ÇÖZÜM()
        {
            InitializeComponent();
        }

        private void ÇÖZÜM_Load(object sender, EventArgs e)
        {
            
            
        }

        private void baslangicdurumu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
