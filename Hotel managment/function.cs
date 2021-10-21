using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_managment
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-TD5OGQB;database=myHotel;integrated security = True";
            return conn;
        }
        public DataSet getData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            MessageBox.Show(" '" + message + "' ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String query) 
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
