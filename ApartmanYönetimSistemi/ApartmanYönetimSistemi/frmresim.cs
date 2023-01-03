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
    public partial class frmresim : Form
    {
        public frmresim()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server = localhost; userid=root;password=123;database=daireler");
        private void verilerigoster()
        {
            baglanti.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select ad, soyad, borclar from apartman", baglanti);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
           baglanti.Close();
            
        }
        private void frmresim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
