using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
   class Facture
    {
        private DAO dao;
        private SqlCommand cmd;
        public Avishan_Facture Get_Facture_Service_Kinds() {

            Avishan_Facture avishan_Facture = new Avishan_Facture();
            dao = new DAO(DBConnection.enConnectionType.source);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT FACTURE_SERVICE_KIND_IN FROM[RASBankAccounting].[dbo].[FACTURE] group by FACTURE_SERVICE_KIND_IN";
            SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            while (sqlDataReader.Read())
            {
                Int32 KIND;
                KIND= sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("FACTURE_SERVICE_KIND_IN"));
                if (KIND == 0) { avishan_Facture.HasSeat = true; }
                if (KIND == 1) { avishan_Facture.HasToGo = true; }
                if (KIND == 2) { avishan_Facture.HasDelivery = true; }

            }

            return avishan_Facture;

        }

    }

    class Avishan_Facture
    {
        public  bool HasSeat { get; set; }
        public bool HasToGo { get; set; }
        public bool HasDelivery { get; set; }
        
    }
}
