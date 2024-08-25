﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RABBIT_TOYS
{
    public class Connect
    {
        SqlConnection con;

        public static string cs = @"Data Source=DHANAMADHU;Initial Catalog=SPMS1;Integrated Security=True";

        public SqlConnection connect()
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                return con;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        
    }
}
