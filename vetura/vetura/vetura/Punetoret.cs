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
    public partial class Punetoret : Form
    {
        public Punetoret()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var d = new ballina();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var d = new veturat();
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

        private void punreset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var d = new Punetoret();
            d.Show();
            this.Hide();

        }

        private void punADD_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturapuntoret]
           ([username]
           ,[nr.leternjoftimit]
           ,[adresa]
           ,[gjinia])
     VALUES
('" + punemri.Text + "', '" + punnrlbox.Text + "', '" + punadresa.Text + "', '" + punM.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Punetori u regjistrua me sukses!");
                
                var d = new Punetoret();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ju lutem Pranoni Kushtet!");
            }



        }
        public static String puntor;

        private void Punetoret_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veturaDataSet7.veturapuntoret' table. You can move, or remove it, as needed.
            this.veturapuntoretTableAdapter1.Fill(this.veturaDataSet7.veturapuntoret);
            label7.Text = kyqu.username;
            // TODO: This line of code loads data into the 'veturaDataSet.veturapuntoret' table. You can move, or remove it, as needed.
            this.veturapuntoretTableAdapter.Fill(this.veturaDataSet.veturapuntoret);


            puntor = dataGridView1.RowCount.ToString();

        }

        private void punDelete_Click(object sender, EventArgs e)
        {
            if (punnrlbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno te pakten Nrumrin e Leternjoftimit per Fshirjen e Puntorit!");
            }

            string nrL = punnrlbox.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";



            string deleteQuery = $"DELETE FROM [dbo].[veturapuntoret] WHERE  [nr.leternjoftimit] = '{nrL}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Punetori u fshij me sukses!");
                    Punetoret d = new Punetoret();
                    d.Show();
                    this.Hide();

                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            punemri.Text = row.Cells[0].Value.ToString();
            punnrlbox.Text = row.Cells[1].Value.ToString();
            punM.Text = row.Cells[3].Value.ToString();
            punadresa.Text = row.Cells[2].Value.ToString();
        }

        private void punEDIT_Click(object sender, EventArgs e)
        {
            if (punnrlbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno te pakten Nrumrin e Leternjoftimit per Perditesimin e Puntorit!");
            }

            string nrL = punnrlbox.Text;

            string connectionString = @"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True";



            string deleteQuery = $"DELETE FROM [dbo].[veturapuntoret] WHERE  [nr.leternjoftimit] = '{nrL}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturapuntoret]
           ([username]
           ,[nr.leternjoftimit]
           ,[adresa]
           ,[gjinia])
     VALUES
('" + punemri.Text + "', '" + punnrlbox.Text + "', '" + punadresa.Text + "', '" + punM.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                if (punnrlbox.Text.Trim().Length == 0)
                {

                }

                else if (rowsAffected > 0)
                {
                    MessageBox.Show("Punetori u perditesua me sukses");
                    Punetoret d = new Punetoret();
                    d.Show();
                    this.Hide();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
