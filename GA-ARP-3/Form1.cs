using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GA_ARP_3
{
    // https://social.msdn.microsoft.com/Forums/tr-TR/e907b0e0-dc46-458c-ba45-a8f30e3ca66d/mssqlde-olan-verileri-datagridviewe-ekiyorum-ve-listelemek-istiyorum?forum=csharptr
    public partial class Form1 : Form

    {
        public List<Araclar> Araclist = new List<Araclar>();
        public List<Musteri> MusteriListesi = new List<Musteri>();
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        private void Form1_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the '_GA_ARP_3DataSet10.Müsteriler' table. You can move, or remove it, as needed.
            this.müsterilerTableAdapter2.Fill(this._GA_ARP_3DataSet10.Müsteriler);

            baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");
            da = new SqlDataAdapter("Select *From Müsteriler order by Acılar", baglanti);
            ds = new DataSet();
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            MusteriGridWiew.DataSource = dt;
            baglanti.Close();
            listBox1.Items.Clear();

            string sql = "SELECT*FROM Müsteriler order by Acılar";
            baglanti.Open();
            komut = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Musteri depo = new Musteri();
                depo.ID = Convert.ToInt32(dr[0]);
                depo.X = Convert.ToDouble(dr[1]);
                depo.Y = Convert.ToDouble(dr[2]);
                depo.Talep = Convert.ToInt32(dr[3]);
                depo.Acılar = Convert.ToDouble(dr[4]);
                MusteriListesi.Add(depo);
            }
            baglanti.Close();

            string sql1 = "SELECT*FROM Arac";
            baglanti.Open();
            komut = new SqlCommand(sql1, baglanti);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                Araclar arac = new Araclar();
                arac.ID = Convert.ToInt32(dr1[0]);
                arac.Kapasite = Convert.ToInt32(dr1[1]);
                arac.Kullanildimi = Convert.ToBoolean(dr1[2]);;
                Araclist.Add(arac);
            }
            baglanti.Close();
           // listBox1.Items.Add(Convert.ToString(Araclist));
            /* SqlCommand komut = new SqlCommand("Select*From Müsteriler order by Acılar", baglanti);
             try
             {
                 baglanti.Open();
                 SqlDataReader dr = komut.ExecuteReader();
                 while (dr.Read())
                 {
                     MusteriListesi.Add(new Musteri(dr));
                 }
             }
             catch {   }
             finally { baglanti.Close(); } */
            /* try
             {
                 baglanti.Open();
                 SqlDataReader dr = komut.ExecuteReader();

                 while (dr.Read())
                 {
                     Araclist.Add(new Araclar(dr));

                 }

             }
             catch { }
             finally { baglanti.Close(); }*/

            int MüşteriSayısı = MusteriGridWiew.RowCount - 1;
            int[] Çözüm = new int[MüşteriSayısı];
            int[] EnİyiÇözüm = new int[MüşteriSayısı];
            int i, j;
            double[,] Uzaklık = new double[MüşteriSayısı, MüşteriSayısı];
            double[] PolarKoordinat = new double[MüşteriSayısı];
            double[] X = new double[MüşteriSayısı - 1];
            double[] Y = new double[MüşteriSayısı - 1];

        
            for (i = 0; i < MüşteriSayısı; i++)
                for (j = 0; j < MüşteriSayısı; j++)
                {
                    Uzaklık[i, j] = Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[1].Value), 2);
                    Uzaklık[i, j] += Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[2].Value), 2);
                    Uzaklık[i, j] = Math.Sqrt(Uzaklık[i, j]);
                    Uzaklık[i, j] = Math.Ceiling(Uzaklık[i, j]);
                   // listBox1.Items.Add(Uzaklık[i, j]);
                }
            /*  for (i = 1; i < MüşteriSayısı; i++)
            {
                PolarKoordinat[i] = Geography.AciHesapla(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value), Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value));
                MusteriGridWiew.Rows[i].Cells[4].Value = PolarKoordinat[i];
                SqlCommand cmd = new SqlCommand("INSERT INTO Müsteriler (ID,X,Y,Talep,Acılar) VALUES (@ID,@X,@Y,@Talep,@Acılar)", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@Talep", Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[4].Value));
                baglanti.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Guzergah = Convert.ToString(MusteriListesi[0].ID);
            int MüsteriSayisi = MusteriListesi.Count;
            int[] Çözüm = new int[MüsteriSayisi];
            int[] EnİyiÇözüm = new int[MüsteriSayisi];
            double[,] Uzaklık = new double[MüsteriSayisi, MüsteriSayisi];
            int i;
            double Sonuç, EnİyiSonuç;
            for (i=0 ; i < MüsteriSayisi; i++)
            {
                Çözüm[i] = i;
            }
            Sonuç = Geography.AmaçFonkHesapla(MüsteriSayisi, Çözüm, Uzaklık);
            Array.Copy(Çözüm, EnİyiÇözüm, Çözüm.Length);
            EnİyiSonuç = Sonuç;
           for(i=0;i<MüsteriSayisi-1 ;i++)
           {
                List<Musteri> bireyinMusterileri = MusteriListesi.CloneList().ToList();
                List<Araclar> bireyinAraclari = Araclist.CloneList().ToList();
                int SuankiMusteri = Convert.ToInt32(bireyinMusterileri[i].ID);
                int SıradakiMüsteri = Convert.ToInt32(bireyinMusterileri[i+1].ID);
                for (int j =0; j <Araclist.Count;j++)
                {
                    for (int a = 0; a < bireyinMusterileri.Count; a++)
                    {
                        if (bireyinMusterileri[a].Talep <= bireyinAraclari[j].Kapasite && bireyinAraclari[j].Kullanildimi == false)
                        {
                            int SuankiTalep = bireyinMusterileri[a].Talep;
                            SuankiMusteri = bireyinMusterileri[a].ID;
                            int Kapasite = bireyinAraclari[j].Kapasite - bireyinMusterileri[a].Talep;
                            SıradakiMüsteri = bireyinMusterileri[a + 1].ID;
                            Guzergah += "*" + Convert.ToString(SıradakiMüsteri);
                            if (bireyinMusterileri[a].ID != 0)
                            {
                                bireyinMusterileri.RemoveAt(a);
                            }

                            if (Kapasite < bireyinMusterileri[a + 1].Talep)
                            {
                                SıradakiMüsteri = bireyinMusterileri[0].ID;
                                bireyinAraclari[j].Kullanildimi = true;
                                Guzergah += "*" + Convert.ToString(SıradakiMüsteri) + "---";
                            }
                            else
                            {
                                SıradakiMüsteri = bireyinMusterileri[a + 1].ID;
                                Guzergah += "*" + Convert.ToString(SıradakiMüsteri);
                            }

                        }

                        else
                        {
                            SıradakiMüsteri = bireyinMusterileri[0].ID;
                            bireyinAraclari[j].Kullanildimi = true;
                        }
                    }
                }
                int Tmp = Çözüm[SuankiMusteri];
                Çözüm[SuankiMusteri] = Çözüm[SıradakiMüsteri];
                Çözüm[SıradakiMüsteri] = Tmp;
                Sonuç = Geography.AmaçFonkHesapla(MüsteriSayisi, Çözüm, Uzaklık);
                if (Sonuç < EnİyiSonuç)
                {
                    Array.Copy(Çözüm, EnİyiÇözüm, Çözüm.Length);
                    EnİyiSonuç = Sonuç;
                }
            }
            for (i = 0; i < EnİyiÇözüm.Length; i++)
            {
                listBox1.Items.Add(String.Format ("{0}\t",Guzergah));
            }
        }
    }
    internal static class Extensions
    {
        public static IList<T> CloneList<T>(this IList<T> list) where T : ICloneable
        {
            return list.Select(item => (T)item.Clone()).ToList();
        }
    }
}
