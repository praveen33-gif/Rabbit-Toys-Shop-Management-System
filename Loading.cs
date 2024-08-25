using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RABBIT_TOYS
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value < 100)
            {
                progressBar.Value += 1;
                label.Text = progressBar.Value.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loading Completed");
                Login L = new Login();
                L.Show();
                this.Hide();
            }

            
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
