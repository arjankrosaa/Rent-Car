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

namespace vetura
{
    public partial class ballina : Form
    {
        public ballina()
        {
            InitializeComponent();
        }

        private void ballpunetoret_Click(object sender, EventArgs e)
        {
            
            Punetoret d = new Punetoret();
            d.Show();
            this.Hide();
        }

        private void ballveturat_Click(object sender, EventArgs e)
        {
            
            var d = new veturat();
            d.Show();
            this.Hide();
        }

        private void ballklientat_Click(object sender, EventArgs e)
        {
           
            var d = new klientat();
            d.Show();
            this.Hide();
        }

        private void ballrent_Click(object sender, EventArgs e)
        {
            
            var d = new rent();
            d.Show();
            this.Hide();
        }

        private void balldil_Click(object sender, EventArgs e)
        {
            
            var d = new kyqu();
            d.Show();
            this.Hide();
        }

        private void ballclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void ballina_Load(object sender, EventArgs e)
        {
           ballpunetornr.Text = Punetoret.puntor;
            ballveturanr.Text = veturat.veturatnr;
            label3.Text = kyqu.username;
            ballrentnr.Text = rent.rentcarpage;
            //ballhyreranr.Text = rent.a1;
            //ballhyreranr.Text = rent.a1;
            // label6.Text = rent.a1;
            // label6.Text= rent.a2;
            ballhyreranr.Text = rent.a2;

        }

        private string a;
        public void SetSumValue(int sum)
        {
            a = sum.ToString();
        }
        private void ballpunetornr_Click(object sender, EventArgs e)
        {

        }
    }
}
