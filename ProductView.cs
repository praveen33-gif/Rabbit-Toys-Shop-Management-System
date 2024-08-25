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
    public partial class ProductView : Form
    {
        SqlConnection con;
        public ProductView()
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


                    using (SqlCommand cmd = new SqlCommand("SELECT PID,PNAME,AMOUNT,VID FROM PRODUCT WHERE PNAME = @pname"))
                    {
                        cmd.Parameters.AddWithValue("@pname", ProductNaME.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            ProDName.Text = sdr["PNAME"].ToString();

                            VendorID.Text = sdr["VID"].ToString();
                            Amount.Text = sdr["AMOUNT"].ToString();
                            ProductID.Text = sdr["PID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Product not found!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ProDName.Clear();
            Amount.Clear();
            VendorID.Clear();
            ProductNaME.Clear();
            ProductID.Clear();
        }

        private void ProductView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProDName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
