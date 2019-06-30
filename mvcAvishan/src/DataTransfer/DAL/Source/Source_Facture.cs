using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
   class Source_Facture
    {
        private DAO dao;
        private SqlCommand cmd;
        public Target_Facture Get_Facture_Service_Kinds() {

            Target_Facture target_Facture = new Target_Facture();
            dao = new DAO(DBConnection.enConnectionType.source);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT FACTURE_SERVICE_KIND_IN FROM[RASBankAccounting].[dbo].[FACTURE] group by FACTURE_SERVICE_KIND_IN";
            SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            while (sqlDataReader.Read())
            {
                Int32 KIND;
                KIND= sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("FACTURE_SERVICE_KIND_IN"));
                if (KIND == 0) { target_Facture.HasSeat = true; }
                if (KIND == 1) { target_Facture.HasToGo = true; }
                if (KIND == 2) { target_Facture.HasDelivery = true; }

            }

            return target_Facture;

        }

    }

    class Target_Facture
    {
        public  bool HasSeat { get; set; }
        public bool HasToGo { get; set; }
        public bool HasDelivery { get; set; }
        
    }
}
