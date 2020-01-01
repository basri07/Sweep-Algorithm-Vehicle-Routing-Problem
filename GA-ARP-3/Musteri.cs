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

    public class Musteri : ICloneable
       
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Musteri()
        {

        }
        public Musteri(int ID, double X, double Y, int Talep,double Acılar)
        {
            this.ID = ID;
            this.X = X;
            this.Y = Y;
            this.Talep = Talep;
            this.Acılar = Acılar;
        }

        public int ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int Talep { get; set; }
        public double Acılar { get; set; }

        /* int _ID;
         double _X;
         double _Y;
         int _Talep;
         double _Acılar;

         public int ID
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
         public double X
         {
             get
             {
                 return _X;
             }

             set
             {
                 _X = value;
             }
         }
         public double Y
         {
             get
             {
                 return _Y;
             }

             set
             {
                 _Y = value;
             }
         }

         public int Talep
         {
             get
             {
                 return _Talep;
             }

             set
             {
                 _Talep= value;
             }
         }

         public double Acılar
         {
             get
             {
                 return _Acılar;
             }

             set
             {
                 _Acılar = value;
             }
         }*/

    }
}

        
        


