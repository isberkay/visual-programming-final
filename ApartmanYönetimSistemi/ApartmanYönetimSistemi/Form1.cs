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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm af = new AnaForm();
            af.Show();
            this.Hide();
            string cs = @"server=localhost;userid=root;password=123;database=kullanicibilgileri";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from kullanici where kullanıcıadı ='" + textBox1.Text + "' AND şifre = '" + textBox2.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("BOŞ ALANLARI DOLDURUN");
                }
                else
                {
                    if (reader.Read())
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("GİRİŞ BAŞARISIZ");
                    }
                   
                }

                textBox1.Text=String.Empty;
                textBox2.Text=String.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';    
        }
    }
}
