using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ApartmanYönetimSistemi
{
    public partial class frmdaireler : Form
    {
        public frmdaireler()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(@"server = localhost; userid=root;password=123;database=daireler");
        private void renkler()
        {
            btndaire1.BackColor = Color.Gray;
            btndaire2.BackColor = Color.Gray;
            btndaire3.BackColor = Color.Gray;
            btndaire4.BackColor = Color.Gray;
            btndaire5.BackColor = Color.Gray;
            btndaire6.BackColor = Color.Gray;
            btndaire7.BackColor = Color.Gray;
            btndaire8.BackColor = Color.Gray;
        }
        private void btndaire1_Click(object sender, EventArgs e)
        {
             renkler();
             btndaire1.BackColor=Color.CadetBlue;
            lbladsoyad.Text = "Talha Aşır";
        }

        private void frmdaireler_Load(object sender, EventArgs e)
        {
            renkler();
           

        }
       
        private void btndaire2_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire2.BackColor=Color.CadetBlue;
            lbladsoyad.Text = "berkay ekit";
        }

        private void btndaire3_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire3.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "Arzu Durdu";
        }

        private void btndaire4_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire4.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "Yusuf Çayır";
        }

        private void btndaire5_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire5.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "umutcan gülher";
        }

        private void btndaire6_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire6.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "Kamil Mert";
        }

        private void btndaire7_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire7.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "Eren Demir";
        }

        private void btndaire8_Click(object sender, EventArgs e)
        {
            renkler();
            btndaire8.BackColor = Color.CadetBlue;
            lbladsoyad.Text = "Seda Sağlam";
        }
    }
}
