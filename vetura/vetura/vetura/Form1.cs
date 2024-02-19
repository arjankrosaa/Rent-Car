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
    public partial class kyqu : Form
    {
        public kyqu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          //  var a = new regjistrohu();
          //  a.Show();
        }

        private void logregjistrohubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new regjistrohu();
            dritarja.Show();
           
        }

        private void logclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public static string username;
        

        private void logkyqubtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
            String query = "Select * from veturaregjistrimi where username = '" + logusernamebox.Text.Trim() + "'and password= '" + logpasswordbox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            if (logusernamebox.Text.Trim().Length == 0 || logpasswordbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat!");
            }
            else if (dtb.Rows.Count == 1)
            {
                username = logusernamebox.Text;
                //this.Hide();
              //  var dritarja = new ballina();
               // dritarja.Show();

                ballina b = new ballina();
                b.Show();
                this.Hide();


           

            }
            else
            {
                MessageBox.Show("Perdoruesi ose FjaleKalimi jon gabim!");
            }
            
           
        }

        private void kyqu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
