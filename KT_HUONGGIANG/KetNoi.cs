using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace KT_HUONGGIANG
{
    public class KetNoi
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        string strConnect = null;
        public KetNoi()
        {
            strConnect = ConfigurationManager.ConnectionStrings["KetNoi"].ToString();
        }
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(strConnect);
            return conn;
        }
    }
}

