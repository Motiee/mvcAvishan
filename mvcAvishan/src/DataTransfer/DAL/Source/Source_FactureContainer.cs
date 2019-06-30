using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
    class Source_FactureContainer
    {
        private DAO dao;
        private SqlCommand cmd;
        public List<Target_FactureContiner> Get_Ware_and_Quantity()
        {

           List<Target_FactureContiner> list = new List<Target_FactureContiner>();
            dao = new DAO(DBConnection.enConnectionType.source);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT  [WARE_ID],sum([FACTURE_CONTAINER_WARE_QUANTITY_VC])*-1 as WARE_QUANTITY FROM[RASBankAccounting].[dbo].[FACTURE_CONTAINER] group by[WARE_ID] order by[WARE_ID]";
            SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            while (sqlDataReader.Read())
            {
               
                list.Add(new Target_FactureContiner(Convert.ToInt32( sqlDataReader["WARE_ID"]), Convert.ToInt32( sqlDataReader["WARE_QUANTITY"])));
            }

            return list;

        }
    }

    class Target_FactureContiner
    {
        public int WareId { get; set; }
        public int UserRate { get; set; }
        public Target_FactureContiner(int WareId,int UserRate) {
            this.WareId = WareId;
            this.UserRate = UserRate;

        }
        
       
    }
}
