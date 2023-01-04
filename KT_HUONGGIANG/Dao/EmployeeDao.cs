using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KT_HUONGGIANG.Logic;
namespace KT_HUONGGIANG.Dao
{
    internal class EmployeeDao
    {
        KetNoi kn = new KetNoi();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;

        public EmployeeDao()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList()
        {
            string sql = "select Employee.IdEmployee,Employee.Name,Employee.DateBirth,Employee.Gender,Employee.PlaceBirth,Employee.IdDepartment from Employee inner join Department on Employee.IdDepartment=Department.IdDepartment";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt; ;
        }
        public void Insert(Employee nv)
        {
            string sql = "insert into Employee(IdEmployee,Name,DateBirth,Gender,PlaceBirth,IdDepartment)";
            sql += "VALUES ('" + nv.IdEmployee + "','" + nv.Name + "','" + nv.DateBirth + "'," +
                "'" + nv.Gender + "','" + nv.PlaceBirth + "','" + nv.IdDepartment + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(Employee nv)
        {
            string sql = "UPDATE Employee SET Name=N'" + nv.Name + "',DateBirth='" + nv.DateBirth + "',Gender='" + nv.Gender + "',PlaceBirth='" + nv.PlaceBirth + "',IdDepartment='"+nv.IdDepartment+"'";
            sql += "WHERE IdEmployee='" + nv.IdEmployee + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string ma)
        {
            string sql = "DELETE FROM Employee WHERE IdEmployee='" + ma + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
