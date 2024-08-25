using RABBIT_TOYS.mANAGEMENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RABBIT_TOYS
{
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || this.password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = userName.Text;
            string password = this.password.Text;

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Select * from LOGIN where UserName=@username and Password=@password", con);

                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@password", this.password.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Deshboard D = new Deshboard();
                    this.Hide();
                    D.Show();


                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
