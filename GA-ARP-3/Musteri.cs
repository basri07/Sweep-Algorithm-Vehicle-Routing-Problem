using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_ARP_3
{

    public class Musteri
       
    {
        private SqlDataReader dr;

        public Musteri(SqlDataReader dr)
        {
            this.dr = dr;
        }

        /*  public object MusteriID;
            public object Enlem;
            public object Boylam;
            public object SiparisMiktari;
            public Double Uzaklik;*/

       /* public Musteri(object MusteriID,object Enlem, object Boylam, object SiparisMiktari, Double Uzaklik)
        {
            this.MusteriID = MusteriID;
            this.Enlem = Enlem;
            this.Boylam = Boylam;
            this.SiparisMiktari = SiparisMiktari;
            this.Uzaklik = Uzaklik;
        }

        public object MusteriID { get; set; }
        public object Enlem  { get; set; } 
        public object Boylam  { get; set; } 
        public object SiparisMiktari { get; set; }
        public Double Uzaklik { get; set; } */
    }
}
        
        


