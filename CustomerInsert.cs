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
    public partial class CustomerInsert : Form
    {
        private SqlConnection con;
        private static int cid = 1;
        public CustomerInsert()
        {
            InitializeComponent();
        }

        public bool IsEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text == "" || phno.Text == "" || CustomerAddress.Text == "" || CustomerEmail.Text == "" || customerId.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phno.Text.Length != 10)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                string emailAddress = CustomerEmail.Text;
                bool isValid = IsEmailValid(emailAddress);
                if (isValid)
                {
                    Connect connectObj = new Connect();
                    con = connectObj.connect();

                    SqlCommand cmd = new SqlCommand("customer_in", con);


                    //To execute a stored procedure

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cid", customerId.Text);
                    cmd.Parameters.AddWithValue("@cname", CustomerName.Text);
                    cmd.Parameters.AddWithValue("@phone_number", Convert.ToInt64(phno.Text));
                    cmd.Parameters.AddWithValue("@address", CustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@email", CustomerEmail.Text);
                    cid += 1;

                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Customer Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Customer Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Email in correct format");
                }

                //Clear all the textboxes.

                CustomerName.Clear();
                phno.Clear();
                CustomerAddress.Clear();
                CustomerEmail.Clear();
                customerId.Clear();

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

        private void clearButton_Click(object sender, EventArgs e)
        {
            CustomerName.Clear();
            phno.Clear();
            CustomerAddress.Clear();
            CustomerEmail.Clear();
            customerId.Clear();
        }

        private void CustomerInsert_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
