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
    public partial class rent : Form
    {
        public rent()
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            var d = new klientat();
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

        private void rennrtargave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static String rentcarpage;
        public static String a2;
        private void rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veturaDataSet6.veturarentcar' table. You can move, or remove it, as needed.
            this.veturarentcarTableAdapter.Fill(this.veturaDataSet6.veturarentcar);
            label9.Text = kyqu.username;
            // TODO: This line of code loads data into the 'veturaDataSet5.veturaRent' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'veturaDataSet4.veturaKlienti' table. You can move, or remove it, as needed.
            this.veturaKlientiTableAdapter.Fill(this.veturaDataSet4.veturaKlienti);
            // TODO: This line of code loads data into the 'veturaDataSet3.veturaV' table. You can move, or remove it, as needed.
            this.veturaVTableAdapter.Fill(this.veturaDataSet3.veturaV);

            rentcarpage = dataGridView1.RowCount.ToString();

            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }


            a2 = sum.ToString();
            ballina ballina = new ballina();
            //a1.ToString(sum);
        }

        private void renADD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturarentcar]
           ([nr.personal]
           ,[emri]
           ,[nr targave]
           ,[d.qiras]
           ,[d.kthimit]
           ,[cmimi])
     VALUES
('" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox1.Text + "', '" + rendataqiras.Text + "', '" + rendatakthimit.Text + "', '" + rencmimitotal.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Vetura Tani eshte me Qira!");
            
            rent d = new rent();
            d.Show();
            this.Hide();
        }



        public static string a1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void renDELETE_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Trim().Length == 0 || comboBox1.Text.Trim().Length == 0 || comboBox3.Text.Trim().Length == 0 || rencmimitotal.Text.Trim().Length == 0 || rendataqiras.Text.Trim().Length == 0 || rendatakthimit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sheno te gjitha fushat per fshirjen e rentit!");
            }
            else
            {
                string nr_personal = comboBox2.Text;
                string emri = comboBox3.Text;
                string nr_targave = comboBox1.Text;
                

                string d_qiras = rendataqiras.Text;
                string d_kthimit = rendatakthimit.Text;
                string cmimi = rencmimitotal.Text;

                string connectionString = @"Data Source=DESKTOP-IJO9PB9\SQLEXPRESS;Initial Catalog=vetura;Integrated Security=True";

                string deleteQuery = $"DELETE FROM [dbo].[veturarentcar] WHERE [nr.personal] = '{nr_personal}' AND [emri] = '{emri}' AND [nr targave] = '{nr_targave}' AND [d.qiras] = '{d_qiras}' AND [d.kthimit] = '{d_kthimit}' AND [cmimi] = '{cmimi}'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Renti u fshij me sukses!");
                        rent d = new rent();
                        d.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              int indexRow = e.RowIndex;
              DataGridViewRow row = dataGridView1.Rows[indexRow];

              comboBox1.Text = row.Cells[2].Value.ToString();
              comboBox2.Text = row.Cells[0].Value.ToString();
              comboBox3.Text = row.Cells[1].Value.ToString();
              rencmimitotal.Text = row.Cells[5].Value.ToString();
            rendataqiras.Text = row.Cells[3].Value.ToString();
            rendatakthimit.Text = row.Cells[4].Value.ToString();


        }
    }        }
