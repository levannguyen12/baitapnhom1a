using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KT_HUONGGIANG.Dao
{
    internal class DepartmentDao
    {
        KetNoi kn = new KetNoi();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;

        public DepartmentDao()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getData(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
    }
}
