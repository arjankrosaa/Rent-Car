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
    public partial class klientat : Form
    {
        public klientat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var d = new ballina();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            var d = new Punetoret();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var d = new veturat();
            d.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var d = new rent();
            d.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            var d = new kyqu();
            d.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void klientat_Load(object sender, EventArgs e)
        {
            label7.Text = kyqu.username;
            // TODO: This line of code loads data into the 'veturaDataSet2.veturaKlienti' table. You can move, or remove it, as needed.
            this.veturaKlientiTableAdapter.Fill(this.veturaDataSet2.veturaKlienti);

            

        }

        private void kliADD_Click(object sender, EventArgs e)
        {
            if (kliemri.Text.Trim().Length == 0 || klimbiemri.Text.Trim().Length == 0 || klinrpesonal.Text.Trim().Length == 0 || kliphone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Fushat Kryesore per Regjistrim Te Klientit Jane te Zbrasta!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturaKlienti]
           ([emri]
           ,[mbiemri]
           ,[nr.personal]
           ,[phone])
     VALUES
('" + kliemri.Text + "', '" + klimbiemri.Text + "', '" + klinrpesonal.Text + "', '" + kliphone.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Klienti u Regjistrua me sukses!");
               
                klientat d = new klientat();
                d.Show();
                this.Hide();
            }
        }

        private void kliDELETE_Click(object sender, EventArgs e)
        {
            if (klinrpesonal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno te pakten Nrumrin Personal per Fshirjen e Puntorit!");
            }

            string nrL = klinrpesonal.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";



            string deleteQuery = $"DELETE FROM [dbo].[veturaKlienti] WHERE  [nr.personal] = '{nrL}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Klienti u fshij me sukses!");
                    klientat d = new klientat();
                    d.Show();
                    this.Hide();

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            kliemri.Text = row.Cells[0].Value.ToString();
            klimbiemri.Text = row.Cells[1].Value.ToString();
            kliphone.Text = row.Cells[3].Value.ToString();
            klinrpesonal.Text = row.Cells[2].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            klientat d = new klientat();
            d.Show();
            this.Hide();
        }

        private void kliEDIT_Click(object sender, EventArgs e)
        {
            if (klinrpesonal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno te pakten Nrumrin Personal per Perditesimin e Klientit!");
            }

            string nrL = klinrpesonal.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";



            string deleteQuery = $"DELETE FROM [dbo].[veturaKlienti] WHERE  [nr.personal] = '{nrL}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturaKlienti]
           ([emri]
           ,[mbiemri]
           ,[nr.personal]
           ,[phone])
     VALUES
('" + kliemri.Text + "', '" + klimbiemri.Text + "', '" + klinrpesonal.Text + "', '" + kliphone.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                if (klinrpesonal.Text.Trim().Length == 0)
                {

                }

                else if (rowsAffected > 0)
                {
                    MessageBox.Show("Klienti u Perditesua me Sukses!");
                    klientat d = new klientat();
                    d.Show();
                    this.Hide();
                }
            }
        }
    }
}
