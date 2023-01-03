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
    public partial class odemeler : Form
    {
        public odemeler()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server = localhost; userid=root;password=123;database=daireler");

        private void verilerigoster()
        {
            baglanti.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from odemeler", baglanti);
            DataTable fn = new DataTable();
            sqlda.Fill(fn);
            dataGridView1.DataSource = fn;
            baglanti.Close();
        }
        private void odemeler_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
    }
}
