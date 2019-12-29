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
            // TODO: This line of code loads data into the '_GA_ARP_3DataSet8.Müsteriler' table. You can move, or remove it, as needed.
  

            this.aracTableAdapter.Fill(this._GA_ARP_3DataSet6.Arac);
           // this.müsterilerTableAdapter.Fill(this._GA_ARP_3DataSet4.Müsteriler);
            baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");
            da = new SqlDataAdapter("Select *From Müsteriler", baglanti);
            ds = new DataSet();
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            MusteriGridWiew.DataSource = dt;
            baglanti.Close();

            listBox1.Items.Clear();
            SqlCommand komut = new SqlCommand("Select*From Müsteriler", baglanti);
            try
            {
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
               
                while (dr.Read())
                {
                    Musteri depo = new Musteri(dr);
                    MusteriListesi.Add(depo);
                   
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
                    listBox1.Items.Add(Uzaklık[i, j]);
                }
            for (i = 1; i < MüşteriSayısı; i++)
            {

                PolarKoordinat[i] = Geography.AciHesapla(Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[1].Value), Convert.ToDouble(MusteriGridWiew.Rows[i].Cells[2].Value));
               // listBox1.Items.Add(PolarKoordinat[i]);
            }
        }

        public int SıradakiMüsteriID;
        private void button1_Click(object sender, EventArgs e)
        {
            int MüsteriSayisi = MusteriGridWiew.RowCount;

            int i = 0;
            int MusteriID = i;
            for (i = 0; i < MüsteriSayisi; i++)
            {
                int MusteriTalep = Convert.ToInt32(MusteriGridWiew.Rows[i].Cells[3].Value);

                for (int j = 0; j < AracGridWiew.RowCount; j++)
                {
                    int AracKapasitesi = Convert.ToInt32(AracGridWiew.Rows[j].Cells[2].Value);

                    if (MusteriTalep < AracKapasitesi)
                    {

                        MusteriID = i;
                        SıradakiMüsteriID = i + 1;
                        AracKapasitesi = AracKapasitesi - MusteriTalep;
                        MüsteriSayisi = MüsteriSayisi - 1;
                    }
                    else
                    {
                        SıradakiMüsteriID = 0;
                    }
                }
            }
        }
    }
}
