using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace SansuPayrollSystemManagement.Services
{
    internal class DBHelper
    {
        private readonly string connStr;

        public DBHelper()
        {
            connStr = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public DataTable GetData(string sql, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = new MySqlCommand(sql, conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                da.Fill(dt);
            }
            return dt;
        }

        public object ExecuteScalar(string sql, MySqlParameter[] parameters = null)
        {
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public int ExecuteNonQuery(string sql, MySqlParameter[] parameters = null)
        {
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
