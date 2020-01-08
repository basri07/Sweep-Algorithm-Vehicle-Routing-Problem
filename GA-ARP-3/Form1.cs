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
            // TODO: This line of code loads data into the '_GA_ARP_3DataSet2.Müsteriler' table. You can move, or remove it, as needed.
            this.müsterilerTableAdapter3.Fill(this._GA_ARP_3DataSet2.Müsteriler);


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
            while (dr.Read())
            {
                Musteri depo = new Musteri();
                depo.ID = Convert.ToInt32(dr[0]);
                depo.X = Convert.ToDouble(dr[1]);
                depo.Y = Convert.ToDouble(dr[2]);
                depo.Talep = Convert.ToInt32(dr[3]);
                depo.Acılar = Convert.ToDouble(dr[4]);
                depo.Gidildimi = Convert.ToBoolean(dr[5]);
                MusteriListesi.Add(depo);
            }
            baglanti.Close();

            string sql1 = "SELECT*FROM Arac ";
            baglanti.Open();
            komut = new SqlCommand(sql1, baglanti);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                Araclar arac = new Araclar();
                arac.ID = Convert.ToInt32(dr1[0]);
                arac.Kapasite = Convert.ToInt32(dr1[1]);
                arac.Kullanildimi = Convert.ToBoolean(dr1[2]); ;
                Araclist.Add(arac);
            }
            baglanti.Close();
            // listBox1.Items.Add(Convert.ToString(Araclist));
          
            int MüşteriSayısı = MusteriGridWiew.RowCount - 1;

            int i, j;
            double[,] Uzaklık = new double[MüşteriSayısı, MüşteriSayısı];



            for (i = 0; i < MüşteriSayısı; i++)
                for (j = 0; j < MüşteriSayısı; j++)
                {
                    Uzaklık[i, j] = Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[1].Value), 2);
                    Uzaklık[i, j] += Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[2].Value), 2);
                    Uzaklık[i, j] = Math.Sqrt(Uzaklık[i, j]);
                    Uzaklık[i, j] = Math.Ceiling(Uzaklık[i, j]);
                    // listBox1.Items.Add(Uzaklık[i, j]);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int MüsteriSayisi = MusteriListesi.Count;
            int[] Çözüm = new int[MüsteriSayisi];
            int[] EnİyiÇözüm = new int[MüsteriSayisi];
            double[,] Uzaklık = new double[MüsteriSayisi, MüsteriSayisi];
            int i, j;
            double Sonuç, EnİyiSonuç;
            for (i = 0; i < MüsteriSayisi; i++)
                for (j = 0; j < MüsteriSayisi; j++)
                {
                    Uzaklık[i, j] = Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[1].Value), 2);
                    Uzaklık[i, j] += Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[2].Value), 2);
                    Uzaklık[i, j] = Math.Sqrt(Uzaklık[i, j]);
                    Uzaklık[i, j] = Math.Ceiling(Uzaklık[i, j]);
                    listBox1.Items.Add(Uzaklık[i, j]);
                }
            for (i = 0; i < MüsteriSayisi; i++)
            {
                Çözüm[i] = i;
            }
            Sonuç = Geography.AmaçFonkHesapla(MüsteriSayisi, Çözüm, Uzaklık);
            Array.Copy(Çözüm, EnİyiÇözüm, Çözüm.Length);
            EnİyiSonuç = Sonuç;

            int Mus1,Mus2,Son;


            List<Araclar> bireyinAraclari = Araclist.CloneList().ToList();
            List<Musteri> bireyinMusterileri = MusteriListesi.CloneList().ToList();
            //a'yı burda tanımlamamızın sebebi rota hafızası için
            int a = 0;
            string Guzergah = " ";
            Sonuç = 0;
            for (int b = 0; b < bireyinAraclari.Count; b++)
            {
                if (a == MüsteriSayisi)
                {
                    Mus1 = bireyinMusterileri[0].ID;
                    Guzergah += "*" + Convert.ToString(Mus1);
                    listBox1.Items.Add(String.Format("{0}", Guzergah));
                    Sonuç += Uzaklık[a-1, 0];
                    listBox1.Items.Add(Sonuç.ToString());
                    break;
                }
                if (a != 0 && a<MüsteriSayisi-1) 
                { 
                    Mus1 = bireyinMusterileri[0].ID;
                    Guzergah += "*" + Convert.ToString(Mus1);
                    Sonuç += Uzaklık[0, a];
                }
                for (a = a; a < MüsteriSayisi; a++)
                {
                    try
                    {
                        if (bireyinAraclari[b].Kullanildimi == false && bireyinMusterileri[a].Talep <= bireyinAraclari[b].Kapasite && bireyinMusterileri[a].Gidildimi == false)
                        {
                            Mus1 = bireyinMusterileri[a].ID;
                            bireyinAraclari[b].Kapasite = bireyinAraclari[b].Kapasite - bireyinMusterileri[a].Talep;
                            Guzergah += "*" + Convert.ToString(Mus1);
                            bireyinMusterileri[a].Gidildimi = true;
                            if(bireyinMusterileri[a+1].Talep<bireyinAraclari[b].Kapasite)
                            { 
                            Sonuç += Uzaklık[a, a + 1];
                            }
                        }
                        else
                        {
                            //döngü bitince Yeni araca geçer fakat a değeri kaldığı yerden devam eder.
                            Mus1 = bireyinMusterileri[0].ID;
                            Guzergah += "*" + Convert.ToString(Mus1) + "---";
                            
                            bireyinAraclari[b].Kullanildimi = true;
                            Sonuç += Uzaklık[a-1,0];
                            break;
                        }
                        
                    }
                    catch (Exception)
                    {

                    }
                }
               
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
