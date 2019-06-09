using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HRMserver.DAL
{
    class SqlHelper
    {
        public static int ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            int res = comm.ExecuteNonQuery();
            conn.Close();
            return res;
        }
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            object obj = comm.ExecuteScalar();
            conn.Close();
            return obj;
        }
        public static DataTable GetDataTable(string sql, params SqlParameter[] parameters)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
           

            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.SelectCommand.Parameters.AddRange(parameters);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            return comm.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
