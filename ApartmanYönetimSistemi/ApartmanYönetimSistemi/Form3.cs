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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server = localhost; userid=root;password=123;database=daireler");

        private void verilerigoster()
        {
            baglanti.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from apartman",baglanti);
            DataTable dt = new DataTable();
            sqlda.Fill(dt); 
            dataGridView1.DataSource = dt; 
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           verilerigoster();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("insert into apartman(ad,soyad,daire,telefon,mail,borclar) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", baglanti);
            DataTable dataTable = new DataTable();
            sqlda.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
            baglanti.Close();
            verilerigoster();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(textBox7.Text);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from apartman where id = '" + delete + "'", baglanti);
            MySqlDataReader reader = komut.ExecuteReader();
            if (textBox7.Text == "") 
            {
                MessageBox.Show("Kayıt Silinmedi");
            }
            else
            {
                if(reader.Read())
                {

                }
                MessageBox.Show("Kayıt Silindi");
                reader.Close();
            }
            baglanti.Close();
            komut.Dispose();
        }
        

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
