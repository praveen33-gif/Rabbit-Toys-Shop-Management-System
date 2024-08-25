﻿using System;
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
    public partial class StockInsert : Form
    {
        SqlConnection con;
        public StockInsert()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT PNAME FROM PRODUCT WHERE PID = @pid"))
                    {
                        cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            PRoductName.Text = sdr["PNAME"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Product not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ProductID.Text == "" || Quantity.Text == "" || PRoductName.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();

                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Insert into STOCK (PID,QUANTITY) values(@pID,@quantity);", con);

                cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                int i = cmd.ExecuteNonQuery();
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Stock Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Stock Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                //Clear all the fields
                ProductID.Clear();
                Quantity.Clear();
                PRoductName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();

                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ProductID.Clear();
            Quantity.Clear();
            PRoductName.Clear();
        }

        private void StackInsert_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StackInsert_Load(object sender, EventArgs e)
        {

        }

        private void PRoductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
