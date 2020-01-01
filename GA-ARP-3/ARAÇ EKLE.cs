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
    public partial class ARAÇ_EKLE : MetroFramework.Forms.MetroForm
    {
        public ARAÇ_EKLE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter dap;
        DataSet ds;
        SqlCommand komut;
        public void griddoldur()
        {
            baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");
            dap = new SqlDataAdapter("Select *From Arac", baglanti);
            ds = new DataSet();
            baglanti.Open();
            dap.Fill(ds, "Arac");
            AracGrid.DataSource = ds.Tables["Arac"];
            baglanti.Close();
        }

        private void ARAÇ_EKLE_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void Ekle_Button_Click(object sender, EventArgs e)
        {
            bool Kullanıldımı = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO Arac (ID,Kapasite,Kullanıldımı) VALUES (@ID,@Kapasite,@Kullanıldımı)", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id_TextBox.Text));
            cmd.Parameters.AddWithValue("@Kapasite", Convert.ToInt32(Kapasite_TextBoz.Text));
            cmd.Parameters.AddWithValue("@Kullanıldımı", Convert.ToBoolean(Kullanıldımı));
            cmd.ExecuteNonQuery();
            AracGrid.Update();
            baglanti.Close();
            griddoldur();
        }
        private void Sil(int id)
        {
            string sql = "DELETE FROM Arac WHERE ID=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void Sil_Button_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow drow in AracGrid.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Sil(id);
            }
            griddoldur();
        }

        private void rasgele_button_Click(object sender, EventArgs e)
        {
            int AracSayisi;
            AracSayisi = Convert.ToInt32(AracSayısı_TextBox.Text);
            AracSayısı_TextBox.Text = Convert.ToString(AracSayisi);
            Random rastgele = new Random();
            for (int i = 0; i < AracSayisi; i++)
            {
                bool Kullanıldımı = false;
                int Kapasite = rastgele.Next(500, 5000);
                id_TextBox.Text = i.ToString();
                Kapasite_TextBoz.Text = Kapasite.ToString();


                SqlCommand cmd = new SqlCommand("INSERT INTO Arac (ID,Kapasite,Kullanıldımı) VALUES (@ID,@Kapasite,@Kullanıldımı)", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id_TextBox.Text));
                cmd.Parameters.AddWithValue("@Kapasite", Convert.ToInt32(Kapasite_TextBoz.Text));
                cmd.Parameters.AddWithValue("@Kullanıldımı", Convert.ToBoolean(Kullanıldımı));
                cmd.ExecuteNonQuery();
                AracGrid.Update();
                baglanti.Close();
                griddoldur();
            }
        }
    }
}
