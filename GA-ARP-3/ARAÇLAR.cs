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

namespace GA_ARP_3
{
    public partial class ARAÇLAR : MetroFramework.Forms.MetroForm
    {

        public ARAÇLAR()
        {
            InitializeComponent();
            
     

        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        public void griddoldur()
        {
            baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");
            da = new SqlDataAdapter("Select *From Arac", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Arac");
            AracGrid.DataSource = ds.Tables["Arac"];
            baglanti.Close();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source = BASRI\\BASRI; Initial Catalog = GA-ARP-3; Integrated Security = True");

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void ARAÇLAR_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_GA_ARP_3DataSet2.Arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            griddoldur();

            //SqlDataAdapter da;
            // DataSet ds;
            // SqlCommandBuilder cmdb;
            // TODO: Bu kod satırı '_GA_ARP_3DataSet.Arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          
         
           // baglanti.Open();
           // da = new SqlDataAdapter("Select * from Arac", baglanti);
           // cmdb = new SqlCommandBuilder(da);
           // ds = new DataSet();
           // da.Fill(ds, "Arac");
           // Araclar_Grid.DataSource = ds.Tables[0];
           // baglanti.Close();
        }

        private void AracEkle_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Arac (ID,Adi,Kapasite,Plaka) VALUES ('"+id_TextBox.Text + "', '" + AracMarka_TextBox.Text+"','"+AracKapasite_TextBox.Text+"','"+AracPlaka_TextBox.Text+"')",baglanti);
       
            baglanti.Open();
            cmd.ExecuteNonQuery();
            //da.Update(ds, "Arac");
            MessageBox.Show("Eklendi");
          
           // id_TextBox.Clear();
           // AracMarka_TextBox.Clear();
            //AracKapasite_TextBox.Clear();
           // AracKapasite_TextBox.Clear();
           // AracPlaka_TextBox.Clear();
         
            AracGrid.Update();
            baglanti.Close();
            griddoldur();
        }
           
        
        
        private void Sil (int id)
        {
            string sql = "DELETE FROM Arac WHERE ID=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            // SqlCommand cmd= new SqlCommand("DELETE Arac WHERE ID = (" + id + ")",baglanti);
            // cmd.ExecuteNonQuery();
            //AracGrid.Update();
            //baglanti.Close();

            foreach (DataGridViewRow drow in AracGrid.SelectedRows)  //Seçili Satırları Silme
            {
                int id= Convert.ToInt32(drow.Cells[0].Value);
                Sil(id);
            }
            griddoldur();
        }

        private void rastgele_Button_Click(object sender, EventArgs e)
        {
            int AracSayisi;
            AracSayisi = Convert.ToInt32(AracSayisi_TexBox.Text);
            AracSayisi_TexBox.Text = Convert.ToString(AracSayisi);
            Random rastgele = new Random();
            for(int i = 0; i<AracSayisi;i++)
            {

                int Kapasite = rastgele.Next(500, 5000);
                id_TextBox.Text = i.ToString();
                AracKapasite_TextBox.Text = Kapasite.ToString();
                AracMarka_TextBox.Text = i.ToString();
                AracPlaka_TextBox.Text = "PLAKA";
                AracMarka_TextBox.Text = "ARAÇ";
                SqlCommand cmd = new SqlCommand("INSERT INTO Arac (ID,Adi,Kapasite,Plaka) VALUES ('" + id_TextBox.Text + "', '" + AracMarka_TextBox.Text + "','" + AracKapasite_TextBox.Text + "','" + AracPlaka_TextBox.Text + "')", baglanti);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                AracGrid.Update();
                baglanti.Close();
                griddoldur();
            }
        }
    }
}
