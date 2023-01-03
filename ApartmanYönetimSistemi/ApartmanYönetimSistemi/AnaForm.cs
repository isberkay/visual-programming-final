using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYönetimSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btndaireler_Click(object sender, EventArgs e)
        {
            frmdaireler fr = new frmdaireler();
            fr.Show();
            this.Hide();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            odemeler od = new odemeler();
            od.Show();

        }

        private void btnveriler_Click(object sender, EventArgs e)
        {
            frmresim frm = new frmresim();
            frm.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            dolar dlr = new dolar();
            dlr.Show();
        }
    }
}
