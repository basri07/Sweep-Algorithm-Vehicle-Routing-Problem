using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_ARP_3
{
    public partial class ANASAYFA : MetroFramework.Forms.MetroForm
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ARAÇLAR form2 = new ARAÇLAR();
            form2.Show();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MÜŞTERİLER form3 = new MÜŞTERİLER();
            form3.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DEPOLAR form4 = new DEPOLAR();
            form4.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Form1 form5 = new Form1();
            form5.Show();
        }
    }
}
