using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
    class Source_TwoPersonCost
    {
        private DAO dao;
        private SqlCommand cmd;
        public int get()
        {


            dao = new DAO(DBConnection.enConnectionType.SourceConnectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT  AVG( WARE.WARE_PRICE_IN)*2 avg " +
                               " FROM WARE INNER JOIN  " +
                                "WARE_CATEGORY ON WARE.WARE_CATEGORY_ID = WARE_CATEGORY.WARE_CATEGORY_ID INNER JOIN "+
                         " WARE_CATEGORY_TYPE ON WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_ID "+
                         " WHERE WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = 1 "+
                         " UNION "+
                         "SELECT  AVG(WARE.WARE_PRICE_IN) * 2 "+
                         "FROM WARE INNER JOIN "+
                         "WARE_CATEGORY ON WARE.WARE_CATEGORY_ID = WARE_CATEGORY.WARE_CATEGORY_ID INNER JOIN "+
                         "WARE_CATEGORY_TYPE ON WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_ID "+
                         "WHERE WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = 2 "+
                         "UNION "+
                         "SELECT   AVG(WARE.WARE_PRICE_IN) * 2 "+
                         "FROM WARE INNER JOIN "+
                         "WARE_CATEGORY ON WARE.WARE_CATEGORY_ID = WARE_CATEGORY.WARE_CATEGORY_ID INNER JOIN "+
                         "WARE_CATEGORY_TYPE ON WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_ID "+
                         "WHERE WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = 3 ";
            SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            int result = 0;
            while (sqlDataReader.Read())
            {

              result +=(int) sqlDataReader[0];
            }

            return result;

        }
    }
}
