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
    public partial class regjistrohu : Form
    {
        public regjistrohu()
        {
            InitializeComponent();
        }

        private void regjistrohu_Load(object sender, EventArgs e)
        {

        }

        private void regjregjistrohubtn_Click(object sender, EventArgs e)
        {
            if (regjusernamebox.Text.Trim().Length == 0 || regjidbox.Text.Trim().Length == 0 || regjemailbox.Text.Trim().Length == 0 || regjpasswordbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Fushat Kryesore per Regjistrim jane te Zbrasta!");
            }
            else
            {
                if (!regjemailbox.Text.Contains("@") || !regjemailbox.Text.Contains("."))
                {
                    MessageBox.Show("Email jo valid!");
                }
                else
                {


                    SqlConnection con = new SqlConnection(@"Data source=DESKTOP-IJO9PB9\SQLEXPRESS ; Initial Catalog=vetura; Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[veturaregjistrimi]
           ([id]
           ,[username]
           ,[email]
           ,[password]
           ,[adresa]
           ,[pozita])
     VALUES
('" + regjidbox.Text + "', '" + regjusernamebox.Text + "', '" + regjemailbox.Text + "', '" + regjpasswordbox.Text + "', '" + regjadresabox.Text + "', '" + regjpozitabox.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Urime u regjistruat me sukses!");
                }
            }
        }
        private void regjclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regjkyqubtn_Click(object sender, EventArgs e)
        {

            var d = new kyqu();
            d.Show();
            this.Hide();
        }
    }

    
}
