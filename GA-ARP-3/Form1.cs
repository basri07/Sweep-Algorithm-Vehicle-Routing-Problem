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
            da = new SqlDataAdapter("Select *From Müsteriler", baglanti);
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



         /*   for (i = 0; i < MüşteriSayısı; i++)
                for (j = 0; j < MüşteriSayısı; j++)
                {
                    Uzaklık[i, j] = Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[1].Value), 2);
                    Uzaklık[i, j] += Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[2].Value), 2);
                    Uzaklık[i, j] = Math.Sqrt(Uzaklık[i, j]);
                    Uzaklık[i, j] = Math.Ceiling(Uzaklık[i, j]);
                    // listBox1.Items.Add(Uzaklık[i, j]);
                }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int MüsteriSayisi = MusteriListesi.Count;
            int[] Çözüm = new int[MüsteriSayisi];
            int[] EnİyiÇözüm = new int[MüsteriSayisi];
            double[,] Uzaklık = new double[MüsteriSayisi, MüsteriSayisi];
            double[] Sonuç = new double[MüsteriSayisi];
            int i, j;
            double EnİyiSonuç;
            for (i = 0; i < MüsteriSayisi; i++)
                for (j = 0; j < MüsteriSayisi; j++)
                {
                    Uzaklık[i, j] = Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[1].Value), 2);
                    Uzaklık[i, j] += Math.Pow(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value) - Convert.ToDouble(MusteriGridWiew.Rows[j].Cells[2].Value), 2);
                    Uzaklık[i, j] = Math.Sqrt(Uzaklık[i, j]);
                    Uzaklık[i, j] = Math.Ceiling(Uzaklık[i, j]);
                    //listBox1.Items.Add(String.Format("{0}\n {1} \n {2}", i, j,Uzaklık[i, j]));
                   
                }
            #region Parçacık Rotaları Süpürme Algoritması Yöntemi ile Oluşturulu
            //a'yı burda tanımlamamızın sebebi rota hafızası için   
            int Mus1, Mus2, Min;
            EnİyiSonuç = 0;
            List<Musteri> bireyinMusterileri = MusteriListesi.CloneList().ToList();
            for (int c = 0;c<MüsteriSayisi-1;c++)
            {
                
                List<Araclar> bireyinAraclari = Araclist.CloneList().ToList();
                //string Guzergah = " ";
                string[] Guzergah = new string[MüsteriSayisi];
                Sonuç[c] = 0;
                listBox1.Items.Add(String.Format("{0}", Guzergah));
                int a = 0;

                if (c != 0 && c < MüsteriSayisi-1)
                {
                  
                    _ = new Musteri();
                   Musteri insert = bireyinMusterileri[1];
                   bireyinMusterileri.RemoveAt(1);
                   bireyinMusterileri.Add(insert);
                    
                    for (int b = 0; b < bireyinAraclari.Count; b++)
                    {

                        if (a != 0 && a < MüsteriSayisi )
                        {
                            Mus1 = bireyinMusterileri[0].ID;
                            Guzergah[c] += "*" + Convert.ToString(Mus1);
                            Mus2 = bireyinMusterileri[a].ID;
                            Sonuç[c] += Uzaklık[Mus1,Mus2];
                        }
                        if (a == MüsteriSayisi)
                        {
                            Mus2 = bireyinMusterileri[0].ID;
                            Guzergah[c] += "*" + Convert.ToString(Mus2);
                            listBox1.Items.Add(String.Format("{0}", Guzergah[c]));
                            Mus1 = bireyinMusterileri[a - 1].ID;
                            Sonuç[c] += Uzaklık[Mus1, Mus2];
                            for (i = 0; i <= c; i++)
                            {
                                if (EnİyiSonuç > Sonuç[i])
                                    EnİyiSonuç = Sonuç[i];
                            }
                            listBox1.Items.Add(Sonuç[c].ToString());
                            listBox1.Items.Add(EnİyiSonuç.ToString());
                            break;
                        }
                        for (a = a; a < MüsteriSayisi; a++)
                        {
                            try
                            {
                                if (bireyinAraclari[b].Kullanildimi == false && bireyinMusterileri[a].Talep <= bireyinAraclari[b].Kapasite && bireyinMusterileri[a].Gidildimi == false)
                                {
                                    Mus1 = bireyinMusterileri[a].ID;
                                    bireyinAraclari[b].Kapasite = bireyinAraclari[b].Kapasite - bireyinMusterileri[a].Talep;
                                    Guzergah[c] += "*" + Convert.ToString(Mus1);
                                    Mus2 = bireyinMusterileri[a+1].ID;
                                    // bireyinMusterileri[a].Gidildimi = true;
                                    if (bireyinMusterileri[a+1].Talep < bireyinAraclari[b].Kapasite)
                                    {
                                        Sonuç[c] += Uzaklık[Mus1, Mus2];
                                    }
                                }
                                else
                                {
                                     //döngü bitince Yeni araca geçer fakat a değeri kaldığı yerden devam eder.
                                     Mus1 = bireyinMusterileri[a - 1].ID;
                                     Mus2 = bireyinMusterileri[0].ID;
                                     Guzergah[c] += "*" + Convert.ToString(Mus2) + "---";
                                     //bireyinAraclari[b].Kullanildimi = true;
                                     Sonuç[c] += Uzaklık[Mus1, Mus2];
                                     break;
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                }
                else
                {
                    for (int b = 0; b < bireyinAraclari.Count; b++)
                    {
                       
                        if (a != 0 && a <MüsteriSayisi)
                        {
                            Mus1 = bireyinMusterileri[0].ID;
                            Guzergah[c] += "*" + Convert.ToString(Mus1);
                            Mus2 = bireyinMusterileri[a].ID;
                            Sonuç[c] += Uzaklık[Mus1, Mus2];
                        }
                        if (a == MüsteriSayisi)
                        {
                            Mus2 = bireyinMusterileri[0].ID;
                            Guzergah[c] += "*" + Convert.ToString(Mus2);
                            listBox1.Items.Add(String.Format("{0}", Guzergah[c]));
                            Mus1 = bireyinMusterileri[a - 1].ID;
                            Sonuç[c] += Uzaklık[Mus1, Mus2];
                            EnİyiSonuç = Sonuç[c];
                            listBox1.Items.Add(Sonuç[c].ToString());
                            listBox1.Items.Add(EnİyiSonuç.ToString());
                            break;
                        }
                        for (a = a; a < MüsteriSayisi; a++)
                        {
                            try
                            {
                                if (bireyinAraclari[b].Kullanildimi == false && bireyinMusterileri[a].Talep <= bireyinAraclari[b].Kapasite && bireyinMusterileri[a].Gidildimi == false)
                                {
                                   Mus1 = bireyinMusterileri[a].ID;
                                   bireyinAraclari[b].Kapasite = bireyinAraclari[b].Kapasite - bireyinMusterileri[a].Talep;
                                   Guzergah[c] += "*" + Convert.ToString(Mus1);
                                   Mus2 = bireyinMusterileri[a + 1].ID;
                                   //bireyinMusterileri[a].Gidildimi = true;
                                    if (bireyinMusterileri[a+1].Talep < bireyinAraclari[b].Kapasite)
                                    {
                                        Sonuç[c] += Uzaklık[Mus1, Mus2];
                                    }
                                } 
                                else
                                {
                                     //döngü bitince Yeni araca geçer fakat a değeri kaldığı yerden devam eder.
                                     Mus1 = bireyinMusterileri[a - 1].ID;
                                     Mus2 = bireyinMusterileri[0].ID;
                                     Guzergah[c] += "*" + Convert.ToString(Mus2) + "---";
                                     bireyinAraclari[b].Kullanildimi = true;
                                     Sonuç[c] += Uzaklık[Mus1, Mus2];
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
            #endregion
            listBox1.Items.Add(EnİyiSonuç.ToString());
        }
    }
    internal static class Extensions
    {
        public static IList<T> CloneList<T>(this IList<T> list) where T : ICloneable
        {
            return list.Select(item => (T)item.Clone()).ToList();
        }
        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }
    }

}
