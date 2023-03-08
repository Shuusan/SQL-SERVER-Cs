using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_KD
{
    internal class SqlServiceBasic
    {
        private string connectionString;
        public SqlServiceBasic(string connectionString) { 
            this.connectionString = connectionString;
        }

        /// <summary>
        /// taking all table data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet getAllTableData(string sql)
        {
            DataSet ds = new DataSet();

            SqlConnection connection = new SqlConnection(connectionString);
            string sqlCmd = sql;

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            try
            {
                connection.Open();
                dataadapter.Fill(ds);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return ds;

        }

        public bool executeSql(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return true;
        }



    }
}
