using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GA_ARP_3
{
    public class Veriişlemleri
    {
        SqlConnection baglanti;
        private static SqlConnection con = new SqlConnection("Data Source=BASRI\\BASRI;Initial Catalog=GA-ARP-3;Integrated Security=True ");
       
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        public static DataTable AracFiltre(string filtre, string aranan)
        {
            string query = "Select * From Arac Where " + filtre + " Like @aranan;";
            SqlDataAdapter da = new SqlDataAdapter(query, BaglantiSinifi.Con);
            da.SelectCommand.Parameters.Add("@aranan", SqlDbType.VarChar).Value = "%" + aranan + "%";
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dt.TableName = "Arac";
                dt.Columns["Adi"].ColumnName = "Marka";
                dt.Columns["Plaka"].ColumnName = "Plaka";
                dt.Columns["Kapasite"].ColumnName = "Kapasite";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            return dt;
        }
        public static DataTable MüsteriFiltre(string filtre, string aranan)
        {
            string query = "Select * From Müsteri Where " + filtre + " Like @aranan;";
            SqlDataAdapter da = new SqlDataAdapter(query, BaglantiSinifi.Con);
            da.SelectCommand.Parameters.Add("@aranan", SqlDbType.VarChar).Value = "%" + aranan + "%";
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dt.TableName = "Müsteri";
                dt.Columns["Adi"].ColumnName = "Adi";
                dt.Columns["X"].ColumnName = "X Koordinatı";
                dt.Columns["Y"].ColumnName = "Y Koordinatı";
                dt.Columns["Siparis_Miktari"].ColumnName = "Sipariş Miktarı";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            return dt;
        }
        public static DataTable AracTabloDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Arac", BaglantiSinifi.Con);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "Arac";
                dt.Columns["Adi"].ColumnName = "Marka";
                dt.Columns["Plaka"].ColumnName = "Plaka";
                dt.Columns["Kapasite"].ColumnName = "Kapasite"; ;
                return dt;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return null;
            }
        }
        public static DataTable MusteriTabloDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Müsteri", BaglantiSinifi.Con);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "Müsteri";
                dt.Columns["Adi"].ColumnName = "Adi";
                dt.Columns["X"].ColumnName = "X Koordinatı";
                dt.Columns["Y"].ColumnName = "Y Koordinatı";
                dt.Columns["Siparis_Miktari"].ColumnName = "Sipariş Miktarı";
                return dt;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return null;
            }
        }
        public static string[] BilgileriAl(string aranan)
        {   // Bu method Veri Düzenleme işlemlerinde Formdaki bileşenlere yerleşecek verileri getirir 
            SqlCommand cmd;
            string[] bilgiler = new string[3];
            cmd = new SqlCommand("Select * From Arac Where ID = " + aranan, BaglantiSinifi.Con);
            try
            {
                BaglantiSinifi.Con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < 3; i++)
                        bilgiler[i] = dr[i].ToString();
                }
            }
            catch (Exception exp)
            { Console.WriteLine(exp.Message); }
            finally
            {
                BaglantiSinifi.Con.Close();
            }
            return bilgiler;
        }
        public static class BaglantiSinifi
        {

            public static SqlConnection Con => con;
        }
        public static bool AracEkle(string Adi, string Kapasite, string Plaka)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Arac(Adi,Kapasite,Plaka) values ([@s1],[@s2],[@s3])", BaglantiSinifi.Con);
            cmd.Parameters.AddWithValue("@s1", Adi);
            cmd.Parameters.AddWithValue("@s2", Kapasite);
            cmd.Parameters.AddWithValue("@s2", Plaka);
            return Sorgu(cmd);
        }
        public static bool Sorgu(SqlCommand cmd)
        {
            try
            {
                if (BaglantiSinifi.Con.State != ConnectionState.Open)
                    BaglantiSinifi.Con.Open();
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
        }
        public static bool KisiDuzenle(string Kisi, string Telefon)
        {
            SqlCommand cmd = new SqlCommand("Update Bilgiler Set Telefon = @s1, Ad_Soyad = @s2", BaglantiSinifi.Con);
            cmd.Parameters.AddWithValue("@s1", Telefon);
            cmd.Parameters.AddWithValue("@s2", Kisi);
            return Sorgu(cmd);
        }
        public static bool VeriSil(string silinecek)
        {
            string sorgu = "Delete From Arac Where Adi = " + silinecek;
            SqlCommand cmd = new SqlCommand(sorgu, BaglantiSinifi.Con);
            return Sorgu(cmd);
        }

    }
}
