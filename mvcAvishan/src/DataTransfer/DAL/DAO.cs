using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL
{
    public class DAO
    {
        private readonly string _connctionString = "";

        public DAO(string connctionString) {
            _connctionString = connctionString;
        }
      

        public object ExecuteScalar(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection(_connctionString);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                ErrorLog(e.Message);
                return null;
            }


        }

        public int ExecuteNonQuery(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection(_connctionString);

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorLog(e.Message);
                return -1;
            }

        }

        public SqlDataReader ExeDataReader(SqlCommand sqlCommand)
        {
            SqlConnection connection = new SqlConnection(_connctionString);
            try
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                ErrorLog(e.Message);
                return null;
            }


        }

        private void ErrorLog(string errorMessage)
        {
            string errorLogPath = String.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "Error\\");

            if (System.IO.Directory.Exists(errorLogPath))
            {
            }
            else
            {
                System.IO.Directory.CreateDirectory(errorLogPath);
            }

            string errorFile = string.Concat(errorLogPath, "[ErrorLog@", DateTime.Now.ToString("yyyy-MM"), "].txt");

            System.IO.File.WriteAllText(errorFile, string.Concat(errorMessage, "\t", "[", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "]", "\n"));



        }
    }
}
