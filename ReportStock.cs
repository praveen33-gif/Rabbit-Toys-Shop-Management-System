using DGVPrinterHelper;
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
    public partial class ReportStock : Form
    {
        SqlConnection con;
        public ReportStock()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter
            {
                Title = "Available Stock Report",//Header
                SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy")),
                SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                PageNumbers = true,
                PageNumberInHeader = false,
                PorportionalColumns = true,
                HeaderCellAlignment = StringAlignment.Near,
                Footer = "Shop Management System",//Footer
                FooterSpacing = 15
            };
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintDataGridView(dataGridView1);
        }

        private void ReportStack_Load(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM CURRENTLY_AVAILABLE_STOCK;";
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
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

        private void ReportStack_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
