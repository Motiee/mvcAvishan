using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;

namespace DataTransfer
{
    public static class DataBaseHelper
    {

        public static List<string> GetInstances() {

            List<string> list = new List<string>();
            list.Add(Environment.MachineName);
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow row in dt.Rows)
            {
                list.Add((String.Format("{0}\\{1}", row["ServerName"].ToString(), row["InstanceName"].ToString())));
            }
            return list;
        }

        public static List<string> GetDatabases(string ServerName)
        {
            List<string> list = new List<string>();
            Server server = new Server(ServerName);
            foreach (Database db in server.Databases)
            {
                list.Add(db.Name);
            }


            return list;
        }

        public static Boolean TestConnection(string ServerName, string UserName, string Password) {

            try
            {

                Server server = new Server(ServerName);

                if (UserName.Length > 0 && Password.Length > 0)
                {
                    server.PingSqlServerVersion(ServerName, UserName, Password);
                }
                else
                {
                    server.PingSqlServerVersion(ServerName);
                }
              

               return true;


            }
            catch
            {
                return false;
            }

                

          

        }
    }
}