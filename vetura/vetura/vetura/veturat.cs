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
    public partial class veturat : Form
    {
        public veturat()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            
            var d = new klientat();
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

        private void vetADD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturaV]
           ([brendi]
           ,[modeli]
           ,[ne dispozicion]
           ,[nr targave])
     VALUES
('" + vetbrendi.Text + "', '" + vetmodeli.Text + "', '" + vetnedispozicion.Text + "', '" + vetnrtargave.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Vetura u regjistrua me sukses!");


 

            veturat d = new veturat();
            d.Show();
            this.Hide();
        }

        



        public static string veturatnr;
        private void veturat_Load(object sender, EventArgs e)
        {
            label7.Text = kyqu.username;
            // TODO: This line of code loads data into the 'veturaDataSet1.veturaV' table. You can move, or remove it, as needed.
            this.veturaVTableAdapter.Fill(this.veturaDataSet1.veturaV);

            veturatnr = dataGridView1.RowCount.ToString();



        }

        private void vetEDIT_Click(object sender, EventArgs e)
        {

            if (vetnrtargave.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno vetem Nr.Targave per Perditesimin e Vetures!");
            }
            /* string brendi = vetbrendi.Text;
             string modeli = vetmodeli.Text;
             string neDispozicion = vetnedispozicion.Text;*/
            string nrTargave = vetnrtargave.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";


            //     string deleteQuery = $"DELETE FROM [dbo].[veturaV] WHERE [brendi] = '{brendi}' AND [modeli] = '{modeli}' AND [ne dispozicion] = '{neDispozicion}' AND [nr targave] = '{nrTargave}'"; 
            string deleteQuery = $"DELETE FROM [dbo].[veturaV] WHERE  [nr targave] = '{nrTargave}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturaV]
           ([brendi]
           ,[modeli]
           ,[ne dispozicion]
           ,[nr targave])
     VALUES
('" + vetbrendi.Text + "', '" + vetmodeli.Text + "', '" + vetnedispozicion.Text + "', '" + vetnrtargave.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               

                if(vetnrtargave.Text.Trim().Length == 0)
                {

                }

                else if (rowsAffected > 0)
                {
                    MessageBox.Show("Vetura u perditesua me sukses");
                    veturat d = new veturat();
                    d.Show();
                    this.Hide();
                }
            }
        }

        private void vetDelete_Click(object sender, EventArgs e)
        {
            if (vetnrtargave.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Sheno vetem Nr.Targave per Fshirjen e Vetures!");
            }
            /* string brendi = vetbrendi.Text;
             string modeli = vetmodeli.Text;
             string neDispozicion = vetnedispozicion.Text;*/
            string nrTargave = vetnrtargave.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";


       //     string deleteQuery = $"DELETE FROM [dbo].[veturaV] WHERE [brendi] = '{brendi}' AND [modeli] = '{modeli}' AND [ne dispozicion] = '{neDispozicion}' AND [nr targave] = '{nrTargave}'"; 
            string deleteQuery = $"DELETE FROM [dbo].[veturaV] WHERE  [nr targave] = '{nrTargave}'"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vetura u fshij me sukses");
                    veturat d = new veturat();
                    d.Show();
                    this.Hide();

                }
               
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int  indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            vetbrendi.Text = row.Cells[0].Value.ToString();
            vetmodeli.Text = row.Cells[1].Value.ToString();
            vetnedispozicion.Text = row.Cells[2].Value.ToString();
            vetnrtargave.Text = row.Cells[3].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void vetnedispozicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}