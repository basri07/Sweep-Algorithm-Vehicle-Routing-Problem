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
            SqlCommand komut = new SqlCommand("Select*From Müsteriler order by Acılar", baglanti);
            try
            {
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
               
                while (dr.Read())
                {
                    MusteriListesi.Add(new Musteri(dr));
                 
                }

            }
            catch { /* error */ }

            finally { baglanti.Close(); }
            try
            {
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Araclist.Add(new Araclar(dr));

                }

            }
            catch { /* error */ }

            finally { baglanti.Close(); }

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
            int MüsteriSayisi = MusteriGridWiew.Rows.Count;
            int[] Çözüm = new int[MüsteriSayisi];
            int[] EnİyiÇözüm = new int[MüsteriSayisi];
            double[,] Uzaklık = new double[MüsteriSayisi, MüsteriSayisi];
            int i = 0;
            double Sonuç, EnİyiSonuç;
            for (i = 0; i < MüsteriSayisi; i++)
            {
                Çözüm[i] = i;
            }
            Sonuç = Geography.AmaçFonkHesapla(MüsteriSayisi, Çözüm, Uzaklık);
            Array.Copy(Çözüm, EnİyiÇözüm, Çözüm.Length);
            EnİyiSonuç = Sonuç;
          
            for (i=0; i<MüsteriSayisi;i++)
            {
                
                for (i = 0; i < MüsteriSayisi; i++)
                {
                    int Pos1, Pos2;
                    for(int j=0; i< AracGridWiew.Rows.Count; j++) 
                    {

                        int Kapasite = Convert.ToInt32(AracGridWiew.Rows[j].Cells[1].Value);
                        int Talep = Convert.ToInt32(MusteriGridWiew.Rows[i].Cells[3].Value);
                        if ((Convert.ToInt32(MusteriGridWiew.Rows[i].Cells[3].Value)<= Convert.ToInt32(AracGridWiew.Rows[j].Cells[1].Value)) ||( Convert.ToBoolean((AracGridWiew.Rows[j].Cells[2].Value) = false)))
                        {
                             Pos1 = Convert.ToInt32(MusteriGridWiew.Rows[i].Cells[0].Value);
                             Pos2 = Convert.ToInt32(MusteriGridWiew.Rows[i].Cells[0].Value)+1;
                             Kapasite = Kapasite - Talep;
                             Talep = Talep - Talep;
                        }
                        else
                        {
                            Pos1 = 0;
                            Pos2 = 0;
                            AracGridWiew.Rows[j].Cells[2].Value = true;
                        }
                        
                        int Tmp = Çözüm[Pos1];
                        Çözüm[Pos1] = Çözüm[Pos2];
                        Çözüm[Pos2] = Tmp;
                        Sonuç = Geography.AmaçFonkHesapla(MüsteriSayisi, Çözüm, Uzaklık);
                        if (Sonuç < EnİyiSonuç)
                        {
                            Array.Copy(Çözüm, EnİyiÇözüm, Çözüm.Length);
                            EnİyiSonuç = Sonuç;
                        }
                    }
                }
                listBox1.Items.Add(String.Format("En İyi Rota = {0}", EnİyiSonuç.ToString()));
                for (i = 0; i < EnİyiÇözüm.Length; i++)
                {
                    listBox1.Items.Add(String.Format("En İyi Rota = {0}", EnİyiÇözüm[i]));
                }
            }

        }
    }
}
