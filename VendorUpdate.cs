using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RABBIT_TOYS
{
    public partial class VendorUpdate : Form
    {
        SqlConnection con;
        public VendorUpdate()
        {
            InitializeComponent();
        }

        public bool IsEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "" || VendorAddress.Text == "" || PhoneNumber.Text == "" || email.Text == "" || VendorID.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string emailAddress = email.Text;
                bool isValid = IsEmailValid(emailAddress);
                if (isValid)
                {
                    Connect connectObj = new Connect();
                    con = connectObj.connect();

                    SqlCommand cmd = new SqlCommand("UPDATE VENDOR SET vname = @vname,address = @address,phone_number = @phno,email = @email WHERE vid = @id;", con);

                    cmd.Parameters.AddWithValue("@id", VendorID.Text);
                    cmd.Parameters.AddWithValue("@vname", VendorName.Text);
                    cmd.Parameters.AddWithValue("@phno", Convert.ToInt64(PhoneNumber.Text));
                    cmd.Parameters.AddWithValue("@address", VendorAddress.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    //cid += 1;
                    int i = cmd.ExecuteNonQuery();
                    //If count is equal to 1, than show frmMain form
                    if (i != 0)
                    {
                        MessageBox.Show("Vendor Updation Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Vendor Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Email in correct format");
                }



                
            }
            catch (Exception)
            {
                MessageBox.Show("Vendor not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            VendorName.Clear();
            VendorAddress.Clear();
            PhoneNumber.Clear();
            email.Clear();
            VendorID.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            VendorName.Clear();
            VendorAddress.Clear();
            PhoneNumber.Clear();
            email.Clear();
            VendorID.Clear();
        }

        private void VendorUpdate_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
