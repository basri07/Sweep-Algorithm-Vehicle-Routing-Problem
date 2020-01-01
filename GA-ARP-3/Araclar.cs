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
        int _ID;
        int _Kapasite;
        Boolean _Kullanıldımı;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Araclar()
        {

        }
        public Araclar(int ID, int Kapasite, Boolean Kullanildimi)
        {
            this.ID = ID;
            this.Kapasite = Kapasite;
            this.Kullanildimi = Kullanildimi;
        }

        public int ID { get; set; }
        public int Kapasite { get; set; }
        public Boolean Kullanildimi { get; set; }

        /* public int ID
         {
             get
             {
                 return _ID;
             }

             set
             {
                 _ID = value;
             }
         }
         public int Kapasite
         {
             get
             {
                 return _Kapasite;
             }

             set
             {
                 _Kapasite= value;
             }
         }
         public Boolean Kullanıldımı
         {
             get
             {
                 return _Kullanıldımı;
             }

             set
             {
                 _Kullanıldımı = value;
             }
         }*/


        /*  private SqlDataReader dr;

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
public object Kullanildimi { get; set; } */
    }
}

