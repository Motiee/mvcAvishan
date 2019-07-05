using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
    class Source_BankPos
    {
        private DAO dao;
        private SqlCommand cmd;
        public bool Get_HasPos()
        {

           
            dao = new DAO(DBConnection.enConnectionType.SourceConnectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT  ([BANK_POS_ID]) FROM [BANK_POS] ";
            SqlDataReader Result = dao.ExeDataReader(cmd);

            return Result.HasRows;
          
        }

   
    }
}
