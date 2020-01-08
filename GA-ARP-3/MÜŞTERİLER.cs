using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GA_ARP_3
{
    public partial class MÜŞTERİLER : MetroFramework.Forms.MetroForm
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        public void Griddoldur()
        {
            baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");
            da = new SqlDataAdapter("Select *From Müsteriler", baglanti);
            ds = new DataSet();
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            MusteriGrid.DataSource = dt;
            baglanti.Close();
        }

        private void MÜŞTERİLER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_GA_ARP_3DataSet.Müsteriler' table. You can move, or remove it, as needed.
            this.müsterilerTableAdapter3.Fill(this._GA_ARP_3DataSet.Müsteriler);
            Griddoldur();


        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AracEkle_Button_Click(object sender, EventArgs e)
        {

            double PolarKoordinat;
            PolarKoordinat = Geography.AciHesapla(Convert.ToDouble(XKoord_TextBox.Text), Convert.ToDouble(YKoord_TextBox.Text));
            PolarKoodinat.Text = PolarKoordinat.ToString();
            bool Gidildimi = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO Müsteriler (ID,X,Y,Talep,Acılar,Gidildimi) VALUES (@ID,@X,@Y,@Talep,@Acılar,@Gidildimi)", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(MusteriID_TextBox.Text));
            cmd.Parameters.AddWithValue("@X", Convert.ToDouble(XKoord_TextBox.Text));
            cmd.Parameters.AddWithValue("@Y", Convert.ToDouble(YKoord_TextBox.Text));
            cmd.Parameters.AddWithValue("@Talep", Convert.ToInt32(MusteriTalep_TextBox.Text));
            cmd.Parameters.AddWithValue("@Acılar", Convert.ToDouble(PolarKoodinat.Text));
            cmd.Parameters.AddWithValue("@Gidildimi", Convert.ToBoolean(Gidildimi));
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Eklendi");
            MusteriGrid.Update();
            baglanti.Close();
            Griddoldur();
        }
        
        private void Sil(int id)
        {
            string sql = "DELETE FROM Müsteriler WHERE ID=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Sil_Button_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            // SqlCommand cmd= new SqlCommand("DELETE Arac WHERE ID = (" + id + ")",baglanti);
            // cmd.ExecuteNonQuery();
            //AracGrid.Update();
            //baglanti.Close();
            foreach (DataGridViewRow drow in MusteriGrid.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Sil(id);
               
            }
            Griddoldur();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            int Müsterisayisi;
            Müsterisayisi = Convert.ToInt32(MüsteriSayisi_TextBox.Text);
            MüsteriSayisi_TextBox.Text = Convert.ToString(Müsterisayisi);

            Random rastgele = new Random();

            for (int i = 1; i < Müsterisayisi+1; i++)
            {

                // string Acılar;
                bool Gidildimi = false;
                int MüsteriAd = rastgele.Next(0, 100);
                double KoordX =rastgele.Next(-200, 200)+rastgele.NextDouble();
                double KoordY = rastgele.Next(-200, 200) + rastgele.NextDouble();
                int Talep = rastgele.Next(10000, 15000);
               // double[] PolarKoordinat = new double[Müsterisayisi];
                string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
                int harf = rastgele.Next(0, harfler.Length);
                MusteriID_TextBox.Text=i.ToString();
                MusteriTalep_TextBox.Text = Talep.ToString();
                XKoord_TextBox.Text = KoordX.ToString();
                YKoord_TextBox.Text = KoordY.ToString();
                double PolarKoordinat;
                PolarKoordinat = Geography.AciHesapla(Convert.ToDouble(XKoord_TextBox.Text), Convert.ToDouble(YKoord_TextBox.Text));
                PolarKoodinat.Text = PolarKoordinat.ToString();
                SqlCommand cmd = new SqlCommand("INSERT INTO Müsteriler (ID,X,Y,Talep,Acılar,Gidildimi) VALUES (@ID,@X,@Y,@Talep,@Acılar,@Gidildimi)",baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(MusteriID_TextBox.Text));
                cmd.Parameters.AddWithValue("@X", Convert.ToDouble(XKoord_TextBox.Text));
                cmd.Parameters.AddWithValue("@Y", Convert.ToDouble(YKoord_TextBox.Text));
                cmd.Parameters.AddWithValue("@Talep", Convert.ToInt32(MusteriTalep_TextBox.Text));
                cmd.Parameters.AddWithValue("@Acılar", Convert.ToDouble(PolarKoodinat.Text));
                cmd.Parameters.AddWithValue("@Gidildimi", Convert.ToBoolean(Gidildimi));
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Eklendi");
                MusteriGrid.Update();
                baglanti.Close();  

            }
            Griddoldur();
        }
    }
}
