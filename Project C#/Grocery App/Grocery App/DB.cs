using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Grocery_App
{
    internal class DB
    {
        SqlConnection con=null;
        SqlCommand com;
        SqlDataAdapter read;
        public DB()
        {
            //con = new SqlConnection("Data Source=DESKTOP-IVVGP4T;Initial Catalog=class;Integrated Security=True");
            //con = new SqlConnection("Data Source=ismpro.database.windows.net;Initial Catalog=project;Persist Security Info=True;User ID=osura;Password=***********");
            con = new SqlConnection("Server = tcp:ismpro.database.windows.net,1433; Initial Catalog = project1; Persist Security Info = False; User ID = osura; Password =@Project123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            con.Open();
            if (con != null)
                MessageBox.Show("ssss");
            con.Close();
        }
        public int command(string quary,byte[] image=null)
        {
            con.Open();
            com = new SqlCommand(quary, con);
            if(image!=null)
            com.Parameters.AddWithValue("@image", image);
            int state = com.ExecuteNonQuery();
            con.Close();
            return state;
        }
        public DataTable reader1(string quary)
        {
            con.Open();
            read = new SqlDataAdapter(quary, con);
            DataTable result = new DataTable();
            read.Fill(result);
            con.Close();
            return result;
        }
        public SqlDataReader reader2(string quary)
        {
            con.Open();
            com = new SqlCommand(quary, con);
            SqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            return reader ;
        }
        public string executescaler(string quary)
        {
            string re=null;
            con.Open();
            com = new SqlCommand(quary, con);
            re = Convert.ToString(com.ExecuteScalar());
            con.Close();
            return re;
        }
    }
}

