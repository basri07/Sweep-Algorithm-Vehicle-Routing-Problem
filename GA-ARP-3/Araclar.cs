using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ARP_3
{
    public class Araclar : ICloneable
    {
        private SqlDataReader dr;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Araclar()
        {

        }
        public Araclar(object ID, object Kapasite, Boolean Kullanildimi)
        {
            this.ID=ID;
            this.Kapasite = Kapasite;
            this.Kullanildimi = Kullanildimi;
        }

        public Araclar(SqlDataReader dr)
        {
            this.dr = dr;
        }

        public object ID { get; set; }
        public object Kapasite { get; set; }
        public object Kullanildimi { get; set; }
    }
}

